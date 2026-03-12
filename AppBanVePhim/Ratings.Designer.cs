
namespace AppBanVePhim
{
    partial class Ratings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AntdUI.MenuItem menuItem16 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem17 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem18 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem19 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem20 = new AntdUI.MenuItem();
            this.panel1 = new AntdUI.Panel();
            this.panel2 = new AntdUI.Panel();
            this.panel3 = new AntdUI.Panel();
            this.menu1 = new AntdUI.Menu();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.totalBill = new System.Windows.Forms.Label();
            this.movieDuration = new System.Windows.Forms.Label();
            this.ticketNum = new System.Windows.Forms.Label();
            this.movieName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.returnBtn = new AntdUI.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.star4 = new System.Windows.Forms.Label();
            this.star3 = new System.Windows.Forms.Label();
            this.star2 = new System.Windows.Forms.Label();
            this.star1 = new System.Windows.Forms.Label();
            this.star5 = new System.Windows.Forms.Label();
            this.submitPicture = new AntdUI.Button();
            this.ratingDel = new AntdUI.Button();
            this.btnRatings = new AntdUI.Button();
            this.picMovie = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReview = new System.Windows.Forms.RichTextBox();
            this.close = new AntdUI.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.returnBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 552);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 552);
            this.panel2.TabIndex = 1;
            this.panel2.Text = "panel2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.menu1);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.totalBill);
            this.panel3.Controls.Add(this.movieDuration);
            this.panel3.Controls.Add(this.ticketNum);
            this.panel3.Controls.Add(this.movieName);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 552);
            this.panel3.TabIndex = 1;
            this.panel3.Text = "panel3";
            // 
            // menu1
            // 
            menuItem16.Name = "menuMovie";
            menuItem16.Text = "Chọn phim";
            menuItem17.Name = "menuPopcorn";
            menuItem17.Text = "Bỏng nước";
            menuItem18.Name = "menuBillings";
            menuItem18.Text = "Thống kê";
            menuItem19.Name = "menuRatings";
            menuItem19.Text = "Đánh giá";
            menuItem20.Name = "menuLogout";
            menuItem20.Text = "Đăng xuất";
            this.menu1.Items.Add(menuItem16);
            this.menu1.Items.Add(menuItem17);
            this.menu1.Items.Add(menuItem18);
            this.menu1.Items.Add(menuItem19);
            this.menu1.Items.Add(menuItem20);
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Mode = AntdUI.TMenuMode.Horizontal_Arrow;
            this.menu1.Name = "menu1";
            this.menu1.ScrollBarBlock = true;
            this.menu1.Size = new System.Drawing.Size(54, 52);
            this.menu1.TabIndex = 36;
            this.menu1.Text = "menu1";
            this.menu1.Trigger = AntdUI.Trigger.Click;
            this.menu1.SelectChanged += new AntdUI.SelectEventHandler(this.menu1_SelectChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // totalBill
            // 
            this.totalBill.AutoSize = true;
            this.totalBill.BackColor = System.Drawing.SystemColors.Window;
            this.totalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBill.Location = new System.Drawing.Point(131, 295);
            this.totalBill.Name = "totalBill";
            this.totalBill.Size = new System.Drawing.Size(46, 16);
            this.totalBill.TabIndex = 10;
            this.totalBill.Text = "0 VNĐ";
            // 
            // movieDuration
            // 
            this.movieDuration.AutoSize = true;
            this.movieDuration.BackColor = System.Drawing.SystemColors.Window;
            this.movieDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieDuration.Location = new System.Drawing.Point(131, 234);
            this.movieDuration.Name = "movieDuration";
            this.movieDuration.Size = new System.Drawing.Size(15, 16);
            this.movieDuration.TabIndex = 9;
            this.movieDuration.Text = "0";
            // 
            // ticketNum
            // 
            this.ticketNum.AutoSize = true;
            this.ticketNum.BackColor = System.Drawing.SystemColors.Window;
            this.ticketNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketNum.Location = new System.Drawing.Point(131, 181);
            this.ticketNum.Name = "ticketNum";
            this.ticketNum.Size = new System.Drawing.Size(15, 16);
            this.ticketNum.TabIndex = 8;
            this.ticketNum.Text = "0";
            // 
            // movieName
            // 
            this.movieName.AutoSize = true;
            this.movieName.BackColor = System.Drawing.SystemColors.Window;
            this.movieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieName.Location = new System.Drawing.Point(131, 129);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(106, 16);
            this.movieName.TabIndex = 7;
            this.movieName.Text = "Không có dữ liệu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày xem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên phim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số lượng vé";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thời lượng phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thành tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin hóa đơn";
            // 
            // returnBtn
            // 
            this.returnBtn.Controls.Add(this.close);
            this.returnBtn.Controls.Add(this.label12);
            this.returnBtn.Controls.Add(this.star4);
            this.returnBtn.Controls.Add(this.star3);
            this.returnBtn.Controls.Add(this.star2);
            this.returnBtn.Controls.Add(this.star1);
            this.returnBtn.Controls.Add(this.star5);
            this.returnBtn.Controls.Add(this.submitPicture);
            this.returnBtn.Controls.Add(this.ratingDel);
            this.returnBtn.Controls.Add(this.btnRatings);
            this.returnBtn.Controls.Add(this.picMovie);
            this.returnBtn.Controls.Add(this.label14);
            this.returnBtn.Controls.Add(this.label13);
            this.returnBtn.Controls.Add(this.label2);
            this.returnBtn.Controls.Add(this.txtReview);
            this.returnBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnBtn.Location = new System.Drawing.Point(372, 0);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(590, 552);
            this.returnBtn.TabIndex = 1;
            this.returnBtn.Text = "panel4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(48, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Số sao:";
            // 
            // star4
            // 
            this.star4.AutoSize = true;
            this.star4.BackColor = System.Drawing.SystemColors.Window;
            this.star4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.star4.ForeColor = System.Drawing.Color.Gray;
            this.star4.Location = new System.Drawing.Point(206, 61);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(32, 31);
            this.star4.TabIndex = 23;
            this.star4.Text = "★";
            this.star4.Click += new System.EventHandler(this.Star_Click);
            this.star4.MouseEnter += new System.EventHandler(this.Star_MouseEnter);
            this.star4.MouseLeave += new System.EventHandler(this.Star_MouseLeave);
            // 
            // star3
            // 
            this.star3.AutoSize = true;
            this.star3.BackColor = System.Drawing.SystemColors.Window;
            this.star3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.star3.ForeColor = System.Drawing.Color.Gray;
            this.star3.Location = new System.Drawing.Point(169, 61);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(32, 31);
            this.star3.TabIndex = 22;
            this.star3.Text = "★";
            this.star3.Click += new System.EventHandler(this.Star_Click);
            this.star3.MouseEnter += new System.EventHandler(this.Star_MouseEnter);
            this.star3.MouseLeave += new System.EventHandler(this.Star_MouseLeave);
            // 
            // star2
            // 
            this.star2.AutoSize = true;
            this.star2.BackColor = System.Drawing.SystemColors.Window;
            this.star2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.star2.ForeColor = System.Drawing.Color.Gray;
            this.star2.Location = new System.Drawing.Point(132, 61);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(32, 31);
            this.star2.TabIndex = 21;
            this.star2.Text = "★";
            this.star2.Click += new System.EventHandler(this.Star_Click);
            this.star2.MouseEnter += new System.EventHandler(this.Star_MouseEnter);
            this.star2.MouseLeave += new System.EventHandler(this.Star_MouseLeave);
            // 
            // star1
            // 
            this.star1.AutoSize = true;
            this.star1.BackColor = System.Drawing.SystemColors.Window;
            this.star1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.star1.ForeColor = System.Drawing.Color.Gray;
            this.star1.Location = new System.Drawing.Point(95, 61);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(32, 31);
            this.star1.TabIndex = 20;
            this.star1.Text = "★";
            this.star1.Click += new System.EventHandler(this.Star_Click);
            this.star1.MouseEnter += new System.EventHandler(this.Star_MouseEnter);
            this.star1.MouseLeave += new System.EventHandler(this.Star_MouseLeave);
            // 
            // star5
            // 
            this.star5.AutoSize = true;
            this.star5.BackColor = System.Drawing.SystemColors.Window;
            this.star5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.star5.ForeColor = System.Drawing.Color.Gray;
            this.star5.Location = new System.Drawing.Point(243, 61);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(32, 31);
            this.star5.TabIndex = 19;
            this.star5.Text = "★";
            this.star5.Click += new System.EventHandler(this.Star_Click);
            this.star5.MouseEnter += new System.EventHandler(this.Star_MouseEnter);
            this.star5.MouseLeave += new System.EventHandler(this.Star_MouseLeave);
            // 
            // submitPicture
            // 
            this.submitPicture.BorderWidth = 1F;
            this.submitPicture.Location = new System.Drawing.Point(222, 427);
            this.submitPicture.Name = "submitPicture";
            this.submitPicture.Size = new System.Drawing.Size(114, 42);
            this.submitPicture.TabIndex = 18;
            this.submitPicture.Text = "Tải ảnh lên";
            this.submitPicture.Click += new System.EventHandler(this.submitPicture_Click);
            // 
            // ratingDel
            // 
            this.ratingDel.BorderWidth = 1F;
            this.ratingDel.Location = new System.Drawing.Point(422, 480);
            this.ratingDel.Name = "ratingDel";
            this.ratingDel.Size = new System.Drawing.Size(135, 41);
            this.ratingDel.TabIndex = 17;
            this.ratingDel.Text = "Xóa đánh giá";
            this.ratingDel.Click += new System.EventHandler(this.btnClearReview_Click);
            // 
            // btnRatings
            // 
            this.btnRatings.BorderWidth = 1F;
            this.btnRatings.Location = new System.Drawing.Point(25, 480);
            this.btnRatings.Name = "btnRatings";
            this.btnRatings.Size = new System.Drawing.Size(135, 41);
            this.btnRatings.TabIndex = 16;
            this.btnRatings.Text = "Gửi đánh giá";
            this.btnRatings.Click += new System.EventHandler(this.btnSendReview_Click);
            // 
            // picMovie
            // 
            this.picMovie.Location = new System.Drawing.Point(179, 285);
            this.picMovie.Name = "picMovie";
            this.picMovie.Size = new System.Drawing.Size(201, 136);
            this.picMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMovie.TabIndex = 15;
            this.picMovie.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Window;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(48, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Ảnh minh họa:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Window;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(48, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Cảm nhận về bộ phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đánh giá";
            // 
            // txtReview
            // 
            this.txtReview.Location = new System.Drawing.Point(25, 128);
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(532, 123);
            this.txtReview.TabIndex = 13;
            this.txtReview.Text = "";
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(562, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 23);
            this.close.TabIndex = 27;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Ratings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 552);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ratings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Ratings_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.returnBtn.ResumeLayout(false);
            this.returnBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.Panel panel2;
        private AntdUI.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private AntdUI.Panel returnBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label movieDuration;
        private System.Windows.Forms.Label ticketNum;
        private System.Windows.Forms.Label movieName;
        private AntdUI.Button submitPicture;
        private AntdUI.Button ratingDel;
        private AntdUI.Button btnRatings;
        private System.Windows.Forms.PictureBox picMovie;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtReview;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label totalBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label star4;
        private System.Windows.Forms.Label star3;
        private System.Windows.Forms.Label star2;
        private System.Windows.Forms.Label star1;
        private System.Windows.Forms.Label star5;
        private AntdUI.Menu menu1;
        private AntdUI.Label close;
    }
}