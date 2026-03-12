using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanVePhim
{
    public partial class PopcornMenu : Form
    {
        public PopcornMenu()
        {
            InitializeComponent();
            popcornCount.Tag = new FoodItem { Name = "Bỏng Ngô", Price = 50000 };
            pepsiCount.Tag = new FoodItem { Name = "Nước ngọt", Price = 30000 };
            singleCount.Tag = new FoodItem { Name = "Combo Bỏng Nước", Price = 70000 };
            coupleCount.Tag = new FoodItem { Name = "Combo Couple 1", Price = 90000 };
            couplePlusCount.Tag = new FoodItem { Name = "Combo Couple 2", Price = 100000 };
            partyCount.Tag = new FoodItem { Name = "Party Combo", Price = 200000 };
        }

        List<FoodItem> orders = new List<FoodItem>();

        private void menu1_SelectChanged(object sender, AntdUI.MenuSelectEventArgs e)
        {
            MenuHandler.HandleMenuSelect(e, this);
        }

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

            if (SharedData.CurrentOrder.MovieName == null)
            {
                if (MessageBox.Show("Bạn chưa chọn phim, quay về chọn?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PopcornMenu movieForm = new PopcornMenu();
                    movieForm.Show();
                    this.Hide();
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
            SharedData.CurrentOrder = new OrderDetail();
            SharedData.SaveToJson();

            ResetForm();

            Billings billingsForm = new Billings();
            billingsForm.Show();
            this.Hide();
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
        private void ResetForm()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is NumericUpDown num)
                    num.Value = 0;
            }
            sumBill.Text = "Tổng tiền: 0 VNĐ";
            orders.Clear();
        }
        private void HasValidOrder(int finalPopcornPrice)
        {
            SharedData.CurrentOrder.PopcornPrices = finalPopcornPrice;

            SharedData.InvoiceList.Add(new OrderDetail
            {
                MovieName = string.IsNullOrEmpty(SharedData.CurrentOrder.MovieName) ? "Không chọn" : SharedData.CurrentOrder.MovieName,
                Theater = string.IsNullOrEmpty(SharedData.CurrentOrder.Theater) ? "Không chọn" : SharedData.CurrentOrder.Theater,
                Date = string.IsNullOrEmpty(SharedData.CurrentOrder.Date) ? "Không chọn" : SharedData.CurrentOrder.Date,
                TimeFrame = string.IsNullOrEmpty(SharedData.CurrentOrder.TimeFrame) ? "Không chọn" : SharedData.CurrentOrder.TimeFrame,
                Ticket = string.IsNullOrEmpty(SharedData.CurrentOrder.Ticket) ? "Không chọn" : SharedData.CurrentOrder.Ticket,
                Seats = SharedData.CurrentOrder.Seats,
                SeatPrices = SharedData.CurrentOrder.SeatPrices,
                PopcornPrices = finalPopcornPrice
            });
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
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int total = 0;
            foreach (Control ctrl in popcornPanel.Controls)
            {
                if (ctrl is NumericUpDown num && num.Value > 0 && num.Tag is FoodItem item)
                {
                    total += item.Price * (int)num.Value;
                }
            }
            sumBill.Text = "Tổng tiền: " + total.ToString("N0") + " VNĐ";
        }
    }
}
