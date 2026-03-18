using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using Newtonsoft.Json;

namespace AppBanVePhim
{
    public static class SharedData
    {
        // ─── Tạo đường dẫn file theo tên người dùng ───
        public static string GetUserFilePath(string fullName)
        {
            // Xóa ký tự không hợp lệ trong tên file
            foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                fullName = fullName.Replace(c.ToString(), "");

            return fullName.Trim() + ".json";
        }

        // ─── Lưu 1 user vào file riêng ───
        public static void SaveUser(UserAccount user)
        {
            string filePath = GetUserFilePath(user.FullName);
            string json = JsonConvert.SerializeObject(user, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        // ─── Đọc user theo tên ───
        public static UserAccount LoadUser(string fullName)
        {
            string filePath = GetUserFilePath(fullName);
            if (!File.Exists(filePath)) return null;

            try
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<UserAccount>(json);
            }
            catch { return null; }
        }

        // ─── Kiểm tra user đã tồn tại chưa ───
        public static UserAccount CurrentUser { get; set; } = null;
        public static bool IsUserExisted(string fullName)
        {
            return File.Exists(GetUserFilePath(fullName));
        }

        // Kiểm tra số điện thoại đã tồn tại chưa
        public static bool IsPhoneTaken(string phone)
        {
            foreach (string file in Directory.GetFiles(".", "user_*.json"))
            {
                try
                {
                    string json = File.ReadAllText(file);
                    UserAccount user = JsonConvert.DeserializeObject<UserAccount>(json);
                    if (user != null && user.Phone == phone.Trim())
                        return true;
                }
                catch { continue; }
            }
            return false;
        }

        // ─── Kiểm tra email đã tồn tại trong bất kỳ file nào chưa ───
        public static bool IsEmailTaken(string email)
        {
            foreach (string file in Directory.GetFiles(".", "*.json"))
            {
                if (Path.GetFileName(file) == "orders.json") continue;

                try
                {
                    string json = File.ReadAllText(file);
                    UserAccount user = JsonConvert.DeserializeObject<UserAccount>(json);
                    if (user != null && user.Email.Equals(email, StringComparison.OrdinalIgnoreCase))
                        return true;
                }
                catch { continue; }
            }
            return false;
        }

        // ─── Object đơn hàng dùng chung ───
        public static OrderDetail CurrentOrder { get; set; } = new OrderDetail();

        // ─── Danh sách hóa đơn dùng chung ───
        public static BindingList<OrderDetail> InvoiceList { get; set; } = new BindingList<OrderDetail>();

        // ─── Lưu danh sách ra file JSON ───
        public static void SaveToJson()
        {
            string fullPath = Path.GetFullPath("orders.json");
            //System.Windows.Forms.MessageBox.Show("Lưu tại: " + fullPath);

            List<OrderDetail> allOrders = new List<OrderDetail>();
            if (File.Exists("orders.json"))
            {
                try
                {
                    string existingJson = File.ReadAllText("orders.json");
                    allOrders = JsonConvert.DeserializeObject<List<OrderDetail>>(existingJson)
                                ?? new List<OrderDetail>();
                }
                catch { allOrders = new List<OrderDetail>(); }
            }

            allOrders.RemoveAll(o => o.Username == CurrentUser?.FullName);
            allOrders.AddRange(InvoiceList);
            File.WriteAllText("orders.json",
                JsonConvert.SerializeObject(allOrders, Formatting.Indented));
        }

        // ─── Đăng xuất ───
        public static void Logout()
        {
            CurrentUser = null;          // xoá user đang đăng nhập
            ResetCurrentOrder();         // reset đơn hàng hiện tại
            InvoiceList.Clear();         // xoá list hóa đơn trong bộ nhớ
        }

        // ─── Đọc dữ liệu từ JSON vào InvoiceList khi khởi động ───
        public static void LoadFromJson()
        {
            string filePath = "orders.json";
            if (!File.Exists(filePath)) return;

            try
            {
                string json = File.ReadAllText(filePath);
                var allOrders = JsonConvert.DeserializeObject<List<OrderDetail>>(json);
                if (allOrders == null) return;

                InvoiceList.Clear();

                foreach (var item in allOrders.Where(o =>
                    o.Username == CurrentUser?.FullName))
                {
                    InvoiceList.Add(item);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private const string SEAT_FILE = "seats.json";

        // ─── Tạo key duy nhất cho mỗi suất chiếu ───
        public static string GetShowKey(string movie, string theater, string date, string timeFrame)
        {
            return $"{movie}|{theater}|{date}|{timeFrame}";
        }

        // ─── Đọc tất cả SeatRecord từ file ───
        public static List<SeatRecord> LoadSeatRecords()
        {
            if (!File.Exists(SEAT_FILE)) return new List<SeatRecord>();
            try
            {
                string json = File.ReadAllText(SEAT_FILE);
                return JsonConvert.DeserializeObject<List<SeatRecord>>(json)
                       ?? new List<SeatRecord>();
            }
            catch { return new List<SeatRecord>(); }
        }

        // ─── Lấy danh sách ghế đã đặt cho 1 suất chiếu ───
        public static List<string> GetBookedSeats(string movie, string theater,
                                                   string date, string timeFrame)
        {
            var records = LoadSeatRecords();
            var match = records.FirstOrDefault(r =>
                r.MovieName == movie &&
                r.Theater == theater &&
                r.Date == date &&
                r.TimeFrame == timeFrame);

            return match?.BookedSeats ?? new List<string>();
        }

        // ─── Lưu ghế vừa đặt vào file ───
        public static void SaveBookedSeats(string movie, string theater,
                                            string date, string timeFrame,
                                            List<string> newSeats)
        {
            var records = LoadSeatRecords();
            var match = records.FirstOrDefault(r =>
                r.MovieName == movie &&
                r.Theater == theater &&
                r.Date == date &&
                r.TimeFrame == timeFrame);

            if (match != null)
            {
                // ─── Thêm ghế mới vào suất đã có ───
                foreach (var seat in newSeats)
                    if (!match.BookedSeats.Contains(seat))
                        match.BookedSeats.Add(seat);
            }
            else
            {
                // ─── Tạo record mới cho suất chưa có ───
                records.Add(new SeatRecord
                {
                    MovieName = movie,
                    Theater = theater,
                    Date = date,
                    TimeFrame = timeFrame,
                    BookedSeats = newSeats
                });
            }

            File.WriteAllText(SEAT_FILE,
                JsonConvert.SerializeObject(records, Formatting.Indented));
        }
        public static void RemoveBookedSeats(OrderDetail order)
        {
            if (!File.Exists(SEAT_FILE)) return;
            try
            {
                var records = LoadSeatRecords();
                var match = records.FirstOrDefault(r =>
                    r.MovieName == order.MovieName &&
                    r.Theater == order.Theater &&
                    r.Date == order.Date &&
                    r.TimeFrame == order.TimeFrame);

                if (match == null) return;

                var seatsToRemove = order.Ticket?
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList() ?? new List<string>();

                foreach (var seat in seatsToRemove)
                    match.BookedSeats.Remove(seat);

                if (match.BookedSeats.Count == 0)
                    records.Remove(match);

                File.WriteAllText(SEAT_FILE,
                    JsonConvert.SerializeObject(records, Formatting.Indented));
            }
            catch { }
        }

        // ─── Reset đơn hàng hiện tại cho khách mới ───
        public static void ResetCurrentOrder()
        {
            CurrentOrder = new OrderDetail();
        }
    }
}