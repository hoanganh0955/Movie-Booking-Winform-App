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
            // ─── 1. Load dữ liệu từ JSON trước ───
            if (SharedData.InvoiceList.Count == 0)
                SharedData.LoadFromJson();
            //MessageBox.Show($"Số đơn hàng: {SharedData.InvoiceList.Count}");
            // ─── 2. Gán DataSource sau khi đã có dữ liệu ───
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = SharedData.InvoiceList;
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
    }
}