
namespace AppBanVePhim
{
    partial class Movie
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
            AntdUI.CarouselItem carouselItem6 = new AntdUI.CarouselItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movie));
            AntdUI.CarouselItem carouselItem7 = new AntdUI.CarouselItem();
            AntdUI.CarouselItem carouselItem8 = new AntdUI.CarouselItem();
            AntdUI.CarouselItem carouselItem9 = new AntdUI.CarouselItem();
            AntdUI.CarouselItem carouselItem10 = new AntdUI.CarouselItem();
            AntdUI.MenuItem menuItem6 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem7 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem8 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem9 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem10 = new AntdUI.MenuItem();
            this.moviePanel = new AntdUI.Panel();
            this.movieTxt = new AntdUI.Label();
            this.movieBanner = new AntdUI.Carousel();
            this.confirmMovie = new AntdUI.ButtonShadow();
            this.arrowRight = new AntdUI.ButtonShadow();
            this.arrowLeft = new AntdUI.ButtonShadow();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menu1 = new AntdUI.Menu();
            this.close = new AntdUI.Label();
            this.moviePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // moviePanel
            // 
            this.moviePanel.Controls.Add(this.movieTxt);
            this.moviePanel.Controls.Add(this.movieBanner);
            this.moviePanel.Controls.Add(this.confirmMovie);
            this.moviePanel.Controls.Add(this.arrowRight);
            this.moviePanel.Controls.Add(this.arrowLeft);
            this.moviePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviePanel.Location = new System.Drawing.Point(0, 0);
            this.moviePanel.Name = "moviePanel";
            this.moviePanel.Size = new System.Drawing.Size(962, 552);
            this.moviePanel.TabIndex = 33;
            this.moviePanel.Text = "panel9";
            // 
            // movieTxt
            // 
            this.movieTxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.movieTxt.BackColor = System.Drawing.SystemColors.Window;
            this.movieTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTxt.Location = new System.Drawing.Point(267, 424);
            this.movieTxt.Name = "movieTxt";
            this.movieTxt.Size = new System.Drawing.Size(479, 50);
            this.movieTxt.TabIndex = 4;
            this.movieTxt.Text = "Thỏ Ơi!!";
            this.movieTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movieBanner
            // 
            this.movieBanner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            carouselItem6.ID = "rabbit";
            carouselItem6.Img = ((System.Drawing.Image)(resources.GetObject("carouselItem6.Img")));
            carouselItem7.ID = "rain";
            carouselItem7.Img = ((System.Drawing.Image)(resources.GetObject("carouselItem7.Img")));
            carouselItem8.ID = "zoo";
            carouselItem8.Img = ((System.Drawing.Image)(resources.GetObject("carouselItem8.Img")));
            carouselItem9.ID = "spider";
            carouselItem9.Img = ((System.Drawing.Image)(resources.GetObject("carouselItem9.Img")));
            carouselItem10.ID = "star";
            carouselItem10.Img = ((System.Drawing.Image)(resources.GetObject("carouselItem10.Img")));
            this.movieBanner.Image.Add(carouselItem6);
            this.movieBanner.Image.Add(carouselItem7);
            this.movieBanner.Image.Add(carouselItem8);
            this.movieBanner.Image.Add(carouselItem9);
            this.movieBanner.Image.Add(carouselItem10);
            this.movieBanner.Location = new System.Drawing.Point(385, 138);
            this.movieBanner.Name = "movieBanner";
            this.movieBanner.Size = new System.Drawing.Size(241, 278);
            this.movieBanner.TabIndex = 1;
            this.movieBanner.Text = "carousel1";
            // 
            // confirmMovie
            // 
            this.confirmMovie.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.confirmMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmMovie.Location = new System.Drawing.Point(414, 480);
            this.confirmMovie.Name = "confirmMovie";
            this.confirmMovie.Shape = AntdUI.TShape.Round;
            this.confirmMovie.Size = new System.Drawing.Size(180, 60);
            this.confirmMovie.TabIndex = 5;
            this.confirmMovie.Text = "Chọn phim";
            this.confirmMovie.Click += new System.EventHandler(this.confirmMovie_Click);
            // 
            // arrowRight
            // 
            this.arrowRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.arrowRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowRight.Location = new System.Drawing.Point(652, 264);
            this.arrowRight.Name = "arrowRight";
            this.arrowRight.Shape = AntdUI.TShape.Circle;
            this.arrowRight.Size = new System.Drawing.Size(62, 54);
            this.arrowRight.TabIndex = 3;
            this.arrowRight.Text = "→";
            this.arrowRight.Click += new System.EventHandler(this.arrowRight_Click);
            // 
            // arrowLeft
            // 
            this.arrowLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.arrowLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowLeft.Location = new System.Drawing.Point(301, 264);
            this.arrowLeft.Name = "arrowLeft";
            this.arrowLeft.Shape = AntdUI.TShape.Circle;
            this.arrowLeft.Size = new System.Drawing.Size(62, 54);
            this.arrowLeft.TabIndex = 2;
            this.arrowLeft.Text = "←";
            this.arrowLeft.Click += new System.EventHandler(this.arrowLeft_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.menu1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 94);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ RẠP CHIẾU PHIM";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 346);
            this.panel3.TabIndex = 1;
            // 
            // menu1
            // 
            menuItem6.Name = "menuMovie";
            menuItem6.Text = "Chọn phim";
            menuItem7.Name = "menuPopcorn";
            menuItem7.Text = "Bỏng nước";
            menuItem8.Name = "menuBillings";
            menuItem8.Text = "Thống kê";
            menuItem9.Name = "menuRatings";
            menuItem9.Text = "Đánh giá";
            menuItem10.Name = "menuLogout";
            menuItem10.Text = "Đăng xuất";
            this.menu1.Items.Add(menuItem6);
            this.menu1.Items.Add(menuItem7);
            this.menu1.Items.Add(menuItem8);
            this.menu1.Items.Add(menuItem9);
            this.menu1.Items.Add(menuItem10);
            this.menu1.Location = new System.Drawing.Point(1, 1);
            this.menu1.Mode = AntdUI.TMenuMode.Horizontal_Arrow;
            this.menu1.Name = "menu1";
            this.menu1.ScrollBarBlock = true;
            this.menu1.Size = new System.Drawing.Size(54, 52);
            this.menu1.TabIndex = 36;
            this.menu1.Text = "menu1";
            this.menu1.Trigger = AntdUI.Trigger.Click;
            this.menu1.SelectChanged += new AntdUI.SelectEventHandler(this.menu1_SelectChanged);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(934, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 23);
            this.close.TabIndex = 27;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.moviePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Movie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie";
            this.moviePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.Panel moviePanel;
        private AntdUI.Label movieTxt;
        private AntdUI.Carousel movieBanner;
        private AntdUI.ButtonShadow confirmMovie;
        private AntdUI.ButtonShadow arrowRight;
        private AntdUI.ButtonShadow arrowLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private AntdUI.Menu menu1;
        private AntdUI.Label close;
    }
}