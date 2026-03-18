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
    public partial class Seats : Form
    {
        public Seats()
        {
            InitializeComponent();
            int id = 1;

            var sortedButtons = seatPanel.Controls.OfType<System.Windows.Forms.Button>()
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
        }

        public void Seats_Load(object sender, EventArgs e)
        {
            nextPanel.Enabled = false;
            LoadBookedSeats();
        }

        private void menu1_SelectChanged(object sender, AntdUI.MenuSelectEventArgs e)
        {
            MenuHandler.HandleMenuSelect(e, this);
        }

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
                PopcornMenu popcornForm = new PopcornMenu();
                popcornForm.Show();
                this.Hide();
            }
            else
            {
                SharedData.CurrentOrder.PopcornPrices = 0;

                SharedData.InvoiceList.Add(new OrderDetail
                {
                    MovieName = SharedData.CurrentOrder.MovieName,
                    Theater = SharedData.CurrentOrder.Theater,
                    Date = SharedData.CurrentOrder.Date,
                    TimeFrame = SharedData.CurrentOrder.TimeFrame,
                    Seats = SharedData.CurrentOrder.Seats,
                    Ticket = SharedData.CurrentOrder.Ticket,
                    PopcornPrices = 0
                });

                SharedData.CurrentOrder = new OrderDetail();
                SharedData.SaveToJson();
                Billings billingsForm = new Billings();
                billingsForm.Show();
                this.Hide();
            }
        }

        private void LoadBookedSeats()
        {
            // ─── Lấy danh sách ghế đã đặt cho suất này ───
            var bookedSeats = SharedData.GetBookedSeats(
                SharedData.CurrentOrder.MovieName,
                SharedData.CurrentOrder.Theater,
                SharedData.CurrentOrder.Date,
                SharedData.CurrentOrder.TimeFrame
            );

            // ─── Block ghế đã đặt — hiện màu xám ───
            foreach (Control ctrl in seatPanel.Controls)
            {
                if (ctrl is Button seat &&
                    bookedSeats.Contains(seat.Tag?.ToString()))
                {
                    seat.Enabled = false;
                    seat.BackColor = Color.Gray; // ← xám = đã có người đặt
                }
            }
        }

        private void confirmSeats_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn ghế!");
                return;
            }

            SharedData.CurrentOrder.Seats = selectedSeats.Count;
            SharedData.CurrentOrder.Ticket = string.Join(", ",
                selectedSeats.Select(s => s.Tag.ToString()));

            // ─── Lưu ghế vừa đặt vào file ───
            var seatTags = selectedSeats.Select(s => s.Tag.ToString()).ToList();
            SharedData.SaveBookedSeats(
                SharedData.CurrentOrder.MovieName,
                SharedData.CurrentOrder.Theater,
                SharedData.CurrentOrder.Date,
                SharedData.CurrentOrder.TimeFrame,
                seatTags
            );

            foreach (Button seat in selectedSeats)
            {
                seat.Enabled = false;
                seat.BackColor = Color.Red; // ← đỏ = vừa đặt bởi user hiện tại
            }

            MessageBox.Show("Đặt ghế thành công!");
            selectedSeats.Clear();
            nextPanel.Enabled = true;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
