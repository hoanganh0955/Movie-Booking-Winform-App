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
    public partial class Movie : Form
    {
        public Movie()
        {
            InitializeComponent();
        }

        private void menu1_SelectChanged(object sender, AntdUI.MenuSelectEventArgs e)
        {
            MenuHandler.HandleMenuSelect(e, this);
        }

        private Theater theaterForm = new Theater();

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
                SharedData.CurrentOrder.MovieName = movieTxt.Text;

                theaterForm.Show(); 
                this.Hide();
            }

            else return;

        }

        private void moviePricesCheck(string movieName)
        {
            switch (movieName)
            {
                case "Thỏ Ơi!!":
                    SharedData.CurrentOrder.SeatPrices = 160000;
                    break;
                case "Mưa Đỏ":
                    SharedData.CurrentOrder.SeatPrices = 150000;
                    break;
                case "Zootropolis 2":
                    SharedData.CurrentOrder.SeatPrices = 110000;
                    break;
                case "Spiderman: Brand New Day":
                    SharedData.CurrentOrder.SeatPrices = 120000;
                    break;
                case "Star Wars: Thần Lực Thức Tỉnh":
                    SharedData.CurrentOrder.SeatPrices = 130000;
                    break;
                default:
                    SharedData.CurrentOrder.SeatPrices = 100000;
                    break;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
