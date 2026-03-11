using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntdUI;
using System.IO;
using Newtonsoft.Json;

namespace AppBanVePhim
{

    public partial class Form1 : Form

    {

        public Form1()

        {

            InitializeComponent();
            int id = 1;

            var sortedButtons = seatPicker.Controls.OfType<System.Windows.Forms.Button>()
                    .OrderBy(b => b.Location.Y)
                    .ThenBy(b => b.Location.X)
                    .ToList();

            foreach (System.Windows.Forms.Button ctrl in sortedButtons)
            {
                if (id <= 16) ctrl.Tag = "A" + id;
                else if (id <= 32) ctrl.Tag = "B" + (id - 16);
                else if (id <= 48) ctrl.Tag = "C" + (id - 32);
                else if (id <= 64) ctrl.Tag = "D" + (id - 48);
                else if (id <= 80) ctrl.Tag = "E" + (id - 64);
                else if (id <= 96) ctrl.Tag = "F" + (id - 80);

                id++;
            }

            popcornCount.Tag = new FoodItem { Name = "Bỏng Ngô", Price = 50000 };
            pepsiCount.Tag = new FoodItem { Name = "Nước ngọt", Price = 30000 };
            singleCount.Tag = new FoodItem { Name = "Combo Bỏng Nước", Price = 70000 };
            coupleCount.Tag = new FoodItem { Name = "Combo Couple 1", Price = 90000 };
            couplePlusCount.Tag = new FoodItem { Name = "Combo Couple 2", Price = 100000 };
            partyCount.Tag = new FoodItem { Name = "Party Combo", Price = 200000 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Đọc dữ liệu cũ từ file nếu file tồn tại
            string filePath = "orders.json";
            invoiceBindingSource.DataSource = mainInvoiceList;
            dataGridView1.DataSource = invoiceBindingSource;
            dataGridView1.AutoGenerateColumns = false;

            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    var loadedList = JsonConvert.DeserializeObject<List<OrderDetail>>(json);
                    if (loadedList != null)
                    {
                        foreach (var item in loadedList)
                        {
                            mainInvoiceList.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu cũ: " + ex.Message);
                }
            }
        }

        //---------------------------------------------------------         Code panel chọn phim        ------------------------------------------//

        private void moviePicker_Click(object sender, EventArgs e)
        {
            moviePanel.BringToFront();
        }

        string[] movies =
        {
            "Thỏ Ơi!!",
            "Mưa Đỏ",
            "Zootropolis 2",
            "Spiderman: Brand New Day",
            "Star Wars: Thần Lực Thức Tỉnh"
        };

        private void arrowRight_Click(object sender, EventArgs e)
        {
            if (movieBanner.SelectIndex < 4)
                movieBanner.SelectIndex++;
            else
                movieBanner.SelectIndex = 0;
            movieTxt.Text = movies[movieBanner.SelectIndex];
        }

        private void arrowLeft_Click(object sender, EventArgs e)
        {
            if (movieBanner.SelectIndex > 0)
                movieBanner.SelectIndex--;
            else
                movieBanner.SelectIndex = 4;
            movieTxt.Text = movies[movieBanner.SelectIndex];
        }

        private void confirmMovie_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Xác nhận chọn {movieTxt.Text}?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                moviePricesCheck(movieTxt.Text);
                currentOrder.MovieName = movieTxt.Text;
                theaterPicker.BringToFront();

            }

            else return;

        }

        private void moviePricesCheck(string movieName)
        {
            switch (movieName)
            {
                case "Thỏ Ơi!!":
                    currentOrder.SeatPrices = 160000; 
                    break;
                case "Mưa Đỏ":
                    currentOrder.SeatPrices = 150000;
                    break;
                case "Zootropolis 2":
                    currentOrder.SeatPrices = 110000; 
                    break;
                case "Spiderman: Brand New Day":
                    currentOrder.SeatPrices = 120000; 
                    break;
                case "Star Wars: Thần Lực Thức Tỉnh":
                    currentOrder.SeatPrices = 130000;
                    break;
                default:
                    currentOrder.SeatPrices = 100000;
                    break;
            }
        }

        private void returnToPrev_Click(object sender, EventArgs e)
        {
            moviePanel.BringToFront();

        }

        //---------------------------------------------------------         Code panel chọn phim        ------------------------------------------//

        //---------------------------------------------------------         Code panel chọn rạp         ------------------------------------------//



        private void theaterConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(theaterCB.Text) || string.IsNullOrWhiteSpace(timeFrameCB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            currentOrder.Theater = theaterCB.Text;
            currentOrder.Date = dateTimePicker1.Text;
            currentOrder.TimeFrame = timeFrameCB.Text;

            theaterCB.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToString();
            timeFrameCB.Text = "";

            seatPicker.BringToFront();
        }



        //---------------------------------------------------------         Code panel chọn rạp         ------------------------------------------//

        //---------------------------------------------------------         Code panel chọn ghế         ------------------------------------------//



        List<System.Windows.Forms.Button> selectedSeats = new List<System.Windows.Forms.Button>();

        private void SeatPicker_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button seat = sender as System.Windows.Forms.Button;
            if (!selectedSeats.Contains(seat))

            {

                // chọn ghế

                selectedSeats.Add(seat);

                seat.BackColor = Color.LightGreen;
                
            }

            else
            {
                // bỏ chọn ghế
                selectedSeats.Remove(seat);
                seat.BackColor = Color.White;
            }

            confirmSeats.Enabled = selectedSeats.Count > 0;
        }

        private void nextPanel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn chọn bỏng nước không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                popcornPanel.BringToFront();
            }
            else
            {
                currentOrder.PopcornPrices = 0;

                mainInvoiceList.Add(new OrderDetail
                {
                    MovieName = currentOrder.MovieName,
                    Theater = currentOrder.Theater,
                    Date = currentOrder.Date,
                    TimeFrame = currentOrder.TimeFrame,
                    Seats = currentOrder.Seats,
                    Ticket = currentOrder.Ticket,
                    PopcornPrices = 0
                });

                currentOrder = new OrderDetail(); 
                saveToJson();
                populateDGV();
                nextPanel.Enabled = false;
                billingPanel.BringToFront();
            }
        }



        private void confirmSeats_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn ghế!");
                return;
            }

            currentOrder.Seats = selectedSeats.Count;
            currentOrder.Ticket = string.Join(", ", selectedSeats.Select(s => s.Tag.ToString()));

            foreach (System.Windows.Forms.Button seat in selectedSeats)
            {
                seat.Enabled = false;
                seat.BackColor = Color.Red;
            }

            MessageBox.Show("Đặt ghế thành công!");

            selectedSeats.Clear();
            nextPanel.Enabled = true;
        }



        //---------------------------------------------------------         Code panel chọn ghế         ------------------------------------------//

        //---------------------------------------------------------         Code panel bỏng nước        ------------------------------------------//

        private void popcorn_Click(object sender, EventArgs e)
        {
            popcornPanel.BringToFront();
        }

        

        List<FoodItem> orders = new List<FoodItem>();

        private void popcornNext_Click(object sender, EventArgs e)
        {
            orders.Clear();
            int totalPopcorn = 0;

            // Duyệt qua các NumericUpDown để lấy danh sách món đã chọn
            foreach (Control ctrl in popcornPanel.Controls)
            {
                if (ctrl is NumericUpDown num && num.Value > 0 && num.Tag is FoodItem item)
                {
                    orders.Add(new FoodItem
                    {
                        Name = item.Name,
                        Price = item.Price,
                        Quantity = (int)num.Value
                    });
                    totalPopcorn += item.Price * (int)num.Value;
                }
            }

            if (currentOrder.MovieName == null)
            {
                if (MessageBox.Show("Bạn chưa chọn phim, quay về chọn?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    moviePanel.BringToFront(); 
                    return;
                }
            }

            // Nếu không chọn gì, hỏi khách có muốn đi tiếp không
            if (orders.Count == 0)
            {
                if (MessageBox.Show("Bạn chưa chọn bỏng nước, tiếp tục đến hóa đơn?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            }

            // Hiển thị hóa đơn bỏng nước (ShowBill bạn đã viết)
            if (orders.Count > 0) ShowBill();

            HasValidOrder(totalPopcorn);
            currentOrder = new OrderDetail();
            saveToJson();
            populateDGV();

            billingPanel.BringToFront();

            sumBill.Text = "Tổng tiền: 0 VNĐ";
            foreach (Control ctrl in popcornPanel.Controls)
            {
                if (ctrl is NumericUpDown num && num.Value > 0)
                {
                    num.Value = 0;
                }
            }
        }

        private void HasValidOrder(int finalPopcornPrice)
        {
            currentOrder.PopcornPrices = finalPopcornPrice;

            OrderDetail record = new OrderDetail
            {
                MovieName = string.IsNullOrEmpty(currentOrder.MovieName) ? "Không chọn" : currentOrder.MovieName,
                Theater = string.IsNullOrEmpty(currentOrder.Theater) ? "Không chọn" : currentOrder.Theater,
                Date = string.IsNullOrEmpty(currentOrder.Date) ? "Không chọn" : currentOrder.Date,
                TimeFrame = string.IsNullOrEmpty(currentOrder.TimeFrame) ? "Không chọn" : currentOrder.TimeFrame,
                Ticket = string.IsNullOrEmpty(currentOrder.Ticket) ? "Không chọn" : currentOrder.Ticket,
                Seats = currentOrder.Seats,
                PopcornPrices = finalPopcornPrice
            };

            mainInvoiceList.Add(record);
        }

        private void NumericUpDown_Changed(object sender, EventArgs e)
        {
            int total = 0;
            foreach (Control ctrl in popcornPanel.Controls)
            {
                if (ctrl is NumericUpDown num && num.Tag is FoodItem item)
                {
                    total += item.Price * (int)num.Value;
                }
            }
            sumBill.Text = "Tổng tiền: " + total.ToString("N0") + " VNĐ";
        }

        private void popcornConfirm_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach (Control ctrl in popcornPanel.Controls)
            {
                if (ctrl is NumericUpDown num && num.Value > 0 && num.Tag is FoodItem item)
                {
                    total += item.Price * (int)num.Value;
                }
            }

            if (total == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một món ăn/nước uống!");
                return;
            }

            MessageBox.Show("Đã xác nhận lựa chọn bỏng nước. Tổng: " + total.ToString("N0") + " VND");
        }

        private void ShowBill()
        {
            if (orders.Count == 0) return;
            else
            {
                string bill = "----- HÓA ĐƠN -----\n\n";
                int total = 0;

                foreach (var item in orders)
                {
                    int price = item.Price * item.Quantity;
                    bill += $"{item.Name} x {item.Quantity} = {price:N0} VND\n";
                    total += price;
                }

                bill += "\n--------------------------";
                bill += $"\n\nTổng tiền: {total:N0} VND";

                DialogResult result = MessageBox.Show(bill, "Hóa đơn");
                if (result != DialogResult.OK) return;
            }
            
        }

        //---------------------------------------------------------         Code panel bỏng nước        ------------------------------------------//

        //---------------------------------------------------------         Code panel thống kê         ------------------------------------------//
        private void populateDGV()
        {
            string filePath = "orders.json";
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);

                // Chuyển đổi JSON trực tiếp thành DataTable
                DataTable dt = JsonConvert.DeserializeObject<DataTable>(json);

                // Gán DataTable làm nguồn dữ liệu
                dataGridView1.DataSource = dt;
            }
        }

        BindingList<OrderDetail> mainInvoiceList = new BindingList<OrderDetail>();
        OrderDetail currentOrder = new OrderDetail();

        private void saveToJson()
        {
            var listToSave = mainInvoiceList.ToList();
            string json = JsonConvert.SerializeObject(listToSave, Formatting.Indented);
            string filePath = "orders.json";
            File.WriteAllText(filePath, json);
        }
        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            saveToJson();
            MessageBox.Show("Đã lưu dữ liệu vào file orders.json thành công!", "Thông báo");
        }

        // Khai báo BindingSource toàn cục
        BindingSource invoiceBindingSource = new BindingSource();
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}