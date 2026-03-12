using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppBanVePhim
{
    public partial class Ratings : Form
    {
        private int selectedStar = 0;
        private Label[] stars;
        private OrderDetail currentOrder;

        public Ratings()
        {
            InitializeComponent();
            InitStars();
        }

        private void Ratings_Load(object sender, EventArgs e)
        {
            if (SharedData.InvoiceList.Count == 0)
                SharedData.LoadFromJson();

            if (SharedData.InvoiceList.Count == 0)
            {
                MessageBox.Show("Không có đơn hàng nào!", "Thông báo");
                return;
            }

            currentOrder = SharedData.InvoiceList[SharedData.InvoiceList.Count - 1];

            // ─── Hiển thị thông tin đơn hàng ───
            if (DateTime.TryParse(currentOrder.Date, out DateTime dt))
                dateTimePicker1.Value = dt;

            movieName.Text = currentOrder.MovieName;
            ticketNum.Text = currentOrder.Seats.ToString();
            movieDuration.Text = currentOrder.TimeFrame;
            totalBill.Text = currentOrder.TotalPrice.ToString("N0") + " VNĐ";
        }

        private void InitStars()
        {
            stars = new Label[] { star1, star2, star3, star4, star5 };
            foreach (Label star in stars)
            {
                star.Click += Star_Click;
                star.MouseEnter += Star_MouseEnter;
                star.MouseLeave += Star_MouseLeave;
            }
        }

        private void Star_Click(object sender, EventArgs e)
        {
            selectedStar = Array.IndexOf(stars, sender as Label) + 1;
            UpdateStars(selectedStar);
        }

        private void Star_MouseEnter(object sender, EventArgs e)
        {
            UpdateStars(Array.IndexOf(stars, sender as Label) + 1);
        }

        private void Star_MouseLeave(object sender, EventArgs e)
        {
            UpdateStars(selectedStar);
        }

        private void UpdateStars(int count)
        {
            for (int i = 0; i < stars.Length; i++)
                stars[i].ForeColor = i < count ? Color.Gold : Color.Gray;
        }

        private void btnSendReview_Click(object sender, EventArgs e)
        {
            if (currentOrder == null)
            {
                MessageBox.Show("Không có đơn hàng nào để đánh giá!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedStar == 0)
            {
                MessageBox.Show("Vui lòng chọn số sao!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentOrder.StarRating = selectedStar;
            currentOrder.Review = txtReview.Text.Trim(); 

            SharedData.SaveToJson();

            MessageBox.Show($"Cảm ơn bạn đã đánh giá {selectedStar} sao!", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Movie movieForm = new Movie();
            movieForm.Show();
            this.Hide();
        }

        private void btnClearReview_Click(object sender, EventArgs e)
        {
            selectedStar = 0;
            UpdateStars(0);
            txtReview.Text = ""; // ← đổi tên đúng
        }

        // ─── Tải ảnh minh họa ───
        private void submitPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog picture = new OpenFileDialog();
            picture.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp";

            if (picture.ShowDialog() == DialogResult.OK)
            {
                picMovie.Image = Image.FromFile(picture.FileName); // ← đổi tên đúng
            }
        }

        private void menu1_SelectChanged(object sender, AntdUI.MenuSelectEventArgs e)
        {
            MenuHandler.HandleMenuSelect(e, this);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}