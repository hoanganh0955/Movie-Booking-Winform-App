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
    public partial class Theater : Form
    {
        Seats seatForm = new Seats();
        public Theater()
        {
            InitializeComponent();
        }
        private void menu1_SelectChanged(object sender, AntdUI.MenuSelectEventArgs e)
        {
            MenuHandler.HandleMenuSelect(e, this);
        }
        private void theaterConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(theaterCB.Text) || string.IsNullOrWhiteSpace(timeFrameCB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SharedData.CurrentOrder.Theater = theaterCB.Text;
            SharedData.CurrentOrder.Date = dateTimePicker1.Text;
            SharedData.CurrentOrder.TimeFrame = timeFrameCB.Text;

            theaterCB.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToString();
            timeFrameCB.Text = "";

            seatForm.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
