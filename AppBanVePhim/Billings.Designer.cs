
namespace AppBanVePhim
{
    partial class Billings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            AntdUI.MenuItem menuItem6 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem7 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem8 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem9 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem10 = new AntdUI.MenuItem();
            this.theater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeFrame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.watchDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popcornPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seatPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingPanel = new AntdUI.Panel();
            this.billingsNextBtn = new AntdUI.ButtonShadow();
            this.buttonShadow2 = new AntdUI.ButtonShadow();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new AntdUI.Label();
            this.menu1 = new AntdUI.Menu();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new AntdUI.ButtonShadow();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.billingPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // theater
            // 
            this.theater.DataPropertyName = "Theater";
            this.theater.HeaderText = "Rạp phim";
            this.theater.Name = "theater";
            this.theater.ReadOnly = true;
            // 
            // timeFrame
            // 
            this.timeFrame.DataPropertyName = "TimeFrame";
            this.timeFrame.HeaderText = "Khung giờ";
            this.timeFrame.Name = "timeFrame";
            this.timeFrame.ReadOnly = true;
            // 
            // watchDate
            // 
            this.watchDate.DataPropertyName = "Date";
            this.watchDate.HeaderText = "Ngày xem";
            this.watchDate.Name = "watchDate";
            this.watchDate.ReadOnly = true;
            // 
            // popcornPrice
            // 
            this.popcornPrice.DataPropertyName = "PopcornPrices";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.popcornPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.popcornPrice.HeaderText = "Giá bỏng/nước";
            this.popcornPrice.Name = "popcornPrice";
            this.popcornPrice.ReadOnly = true;
            // 
            // totalPrice
            // 
            this.totalPrice.DataPropertyName = "TotalPrice";
            dataGridViewCellStyle4.Format = "N0";
            this.totalPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.totalPrice.HeaderText = "Tổng tiền";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // movie
            // 
            this.movie.DataPropertyName = "MovieName";
            this.movie.HeaderText = "Tên phim";
            this.movie.Name = "movie";
            this.movie.ReadOnly = true;
            // 
            // colSeats
            // 
            this.colSeats.DataPropertyName = "Seats";
            this.colSeats.HeaderText = "Số lượng ghế";
            this.colSeats.Name = "colSeats";
            this.colSeats.ReadOnly = true;
            // 
            // ticket
            // 
            this.ticket.DataPropertyName = "Ticket";
            this.ticket.HeaderText = "Ghế";
            this.ticket.Name = "ticket";
            this.ticket.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticket,
            this.colSeats,
            this.movie,
            this.theater,
            this.watchDate,
            this.timeFrame,
            this.popcornPrice,
            this.seatPrices,
            this.totalPrice});
            this.dataGridView1.Location = new System.Drawing.Point(21, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(922, 348);
            this.dataGridView1.TabIndex = 19;
            // 
            // seatPrices
            // 
            this.seatPrices.DataPropertyName = "SeatPrices";
            this.seatPrices.HeaderText = "Giá vé";
            this.seatPrices.Name = "seatPrices";
            this.seatPrices.ReadOnly = true;
            // 
            // billingPanel
            // 
            this.billingPanel.Controls.Add(this.btnDelete);
            this.billingPanel.Controls.Add(this.billingsNextBtn);
            this.billingPanel.Controls.Add(this.buttonShadow2);
            this.billingPanel.Controls.Add(this.dataGridView1);
            this.billingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billingPanel.Location = new System.Drawing.Point(0, 0);
            this.billingPanel.Name = "billingPanel";
            this.billingPanel.Size = new System.Drawing.Size(962, 552);
            this.billingPanel.TabIndex = 37;
            this.billingPanel.Text = "panel9";
            // 
            // billingsNextBtn
            // 
            this.billingsNextBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.billingsNextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingsNextBtn.Location = new System.Drawing.Point(736, 500);
            this.billingsNextBtn.Name = "billingsNextBtn";
            this.billingsNextBtn.Shape = AntdUI.TShape.Round;
            this.billingsNextBtn.Size = new System.Drawing.Size(152, 40);
            this.billingsNextBtn.TabIndex = 20;
            this.billingsNextBtn.Text = "Tiếp tục";
            this.billingsNextBtn.Click += new System.EventHandler(this.billingsNextBtn_Click);
            // 
            // buttonShadow2
            // 
            this.buttonShadow2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonShadow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShadow2.Location = new System.Drawing.Point(87, 500);
            this.buttonShadow2.Name = "buttonShadow2";
            this.buttonShadow2.Shape = AntdUI.TShape.Round;
            this.buttonShadow2.Size = new System.Drawing.Size(152, 40);
            this.buttonShadow2.TabIndex = 5;
            this.buttonShadow2.Text = "Save data";
            this.buttonShadow2.Click += new System.EventHandler(this.btnSaveJson_Click);
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 33);
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
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(426, 500);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shape = AntdUI.TShape.Round;
            this.btnDelete.Size = new System.Drawing.Size(152, 40);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Xóa hóa đơn";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Billings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.billingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billings";
            this.Load += new System.EventHandler(this.Billings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.billingPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn theater;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeFrame;
        private System.Windows.Forms.DataGridViewTextBoxColumn watchDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn popcornPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn movie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticket;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatPrices;
        private AntdUI.Panel billingPanel;
        private AntdUI.ButtonShadow buttonShadow2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private AntdUI.Menu menu1;
        private AntdUI.ButtonShadow billingsNextBtn;
        private AntdUI.Label close;
        private AntdUI.ButtonShadow btnDelete;
    }
}