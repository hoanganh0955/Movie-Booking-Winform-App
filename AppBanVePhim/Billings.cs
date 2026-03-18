using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace AppBanVePhim
{
    public partial class Billings : Form
    {
        public Billings()
        {
            InitializeComponent();
        }

        private void Billings_Load(object sender, EventArgs e)
        {
            SharedData.LoadFromJson(); // ← bỏ điều kiện if

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = SharedData.InvoiceList;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
        private void menu1_SelectChanged(object sender, AntdUI.MenuSelectEventArgs e)
        {
            MenuHandler.HandleMenuSelect(e, this);
        }

        // ─── Lưu thủ công khi bấm nút ───
        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            SharedData.SaveToJson();
            MessageBox.Show("Đã lưu dữ liệu thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void billingsNextBtn_Click(object sender, EventArgs e)
        {
            Ratings rate = new Ratings();
            rate.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = -1;

            // ─── Trường hợp 1: chọn nguyên row ───
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedIndex = dataGridView1.SelectedRows[0].Index;
            }
            // ─── Trường hợp 2: chọn cell ───
            else if (dataGridView1.SelectedCells.Count > 0)
            {
                selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
            }

            // ─── Không chọn gì ───
            if (selectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ─── Hiện thông tin hóa đơn sắp xóa để xác nhận ───
            var order = SharedData.InvoiceList[selectedIndex];
            DialogResult result = MessageBox.Show(
                $"Xác nhận xóa hóa đơn?\n\n" +
                $"Phim: {order.MovieName}\n" +
                $"Rạp: {order.Theater}\n" +
                $"Ngày: {order.Date}\n" +
                $"Tổng tiền: {order.TotalPrice:N0} VNĐ",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            // ─── Xóa và lưu lại ───
            SharedData.RemoveBookedSeats(order);
            SharedData.InvoiceList.RemoveAt(selectedIndex);
            SharedData.SaveToJson();

            MessageBox.Show("Đã xóa hóa đơn thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}