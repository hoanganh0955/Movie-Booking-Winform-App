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
            var listToSave = InvoiceList.ToList();
            string json = JsonConvert.SerializeObject(listToSave, Formatting.Indented);
            File.WriteAllText("orders.json", json);
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
                var loadedList = JsonConvert.DeserializeObject<List<OrderDetail>>(json);
                if (loadedList != null)
                {
                    InvoiceList.Clear();
                    foreach (var item in loadedList)
                        InvoiceList.Add(item);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        // ─── Reset đơn hàng hiện tại cho khách mới ───
        public static void ResetCurrentOrder()
        {
            CurrentOrder = new OrderDetail();
        }
    }
}