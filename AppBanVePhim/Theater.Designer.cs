
namespace AppBanVePhim
{
    partial class Theater
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
            AntdUI.MenuItem menuItem7 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem8 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem9 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem10 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem11 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem12 = new AntdUI.MenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeFrameCB = new System.Windows.Forms.ComboBox();
            this.theaterCB = new System.Windows.Forms.ComboBox();
            this.theaterConfirm = new AntdUI.ButtonShadow();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu1 = new AntdUI.Menu();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.theaterPicker = new AntdUI.Panel();
            this.close = new AntdUI.Label();
            this.panel1.SuspendLayout();
            this.theaterPicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(238, 216);
            this.dateTimePicker1.MaxDate = new System.DateTime(2026, 12, 25, 23, 59, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2026, 3, 9, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(629, 29);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2026, 12, 25, 23, 59, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Thời gian suất chiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Chọn ngày xem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chọn rạp xem";
            // 
            // timeFrameCB
            // 
            this.timeFrameCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeFrameCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFrameCB.FormattingEnabled = true;
            this.timeFrameCB.Items.AddRange(new object[] {
            "08:00 ~ 10:00\t",
            "10:20 ~ 12:20\t",
            "12:40 ~ 14:40\t",
            "15:00 ~ 17:00\t",
            "17:20 ~ 19:20\t",
            "19:40 ~ 21:40\t",
            "22:00 ~ 00:00\t",
            "00:20 ~ 02:20"});
            this.timeFrameCB.Location = new System.Drawing.Point(238, 293);
            this.timeFrameCB.Name = "timeFrameCB";
            this.timeFrameCB.Size = new System.Drawing.Size(629, 32);
            this.timeFrameCB.TabIndex = 7;
            // 
            // theaterCB
            // 
            this.theaterCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.theaterCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theaterCB.FormattingEnabled = true;
            this.theaterCB.Items.AddRange(new object[] {
            "CGV",
            "Beta",
            "Lotte",
            "BHD",
            "Rạp chiếu phim Quốc Gia"});
            this.theaterCB.Location = new System.Drawing.Point(238, 136);
            this.theaterCB.Name = "theaterCB";
            this.theaterCB.Size = new System.Drawing.Size(629, 32);
            this.theaterCB.TabIndex = 6;
            // 
            // theaterConfirm
            // 
            this.theaterConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.theaterConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theaterConfirm.Location = new System.Drawing.Point(366, 464);
            this.theaterConfirm.Name = "theaterConfirm";
            this.theaterConfirm.Shape = AntdUI.TShape.Round;
            this.theaterConfirm.Size = new System.Drawing.Size(221, 56);
            this.theaterConfirm.TabIndex = 5;
            this.theaterConfirm.Text = "Xác nhận";
            this.theaterConfirm.Click += new System.EventHandler(this.theaterConfirm_Click);
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
            // menu1
            // 
            menuItem7.LocalizationText = "";
            menuItem7.Text = "Khách hàng";
            menuItem8.Text = "Chọn phim";
            menuItem9.Text = "Bỏng nước";
            menuItem10.Text = "Thống kê";
            menuItem11.Text = "Đánh giá";
            menuItem12.Text = "Đăng xuất";
            this.menu1.Items.Add(menuItem7);
            this.menu1.Items.Add(menuItem8);
            this.menu1.Items.Add(menuItem9);
            this.menu1.Items.Add(menuItem10);
            this.menu1.Items.Add(menuItem11);
            this.menu1.Items.Add(menuItem12);
            this.menu1.Location = new System.Drawing.Point(1, 1);
            this.menu1.Mode = AntdUI.TMenuMode.Horizontal_Arrow;
            this.menu1.Name = "menu1";
            this.menu1.ScrollBarBlock = true;
            this.menu1.Size = new System.Drawing.Size(54, 52);
            this.menu1.TabIndex = 34;
            this.menu1.Text = "menu1";
            this.menu1.Trigger = AntdUI.Trigger.Click;
            this.menu1.SelectChanged += new AntdUI.SelectEventHandler(this.menu1_SelectChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 42);
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
            // theaterPicker
            // 
            this.theaterPicker.Controls.Add(this.dateTimePicker1);
            this.theaterPicker.Controls.Add(this.label4);
            this.theaterPicker.Controls.Add(this.label3);
            this.theaterPicker.Controls.Add(this.label2);
            this.theaterPicker.Controls.Add(this.timeFrameCB);
            this.theaterPicker.Controls.Add(this.theaterCB);
            this.theaterPicker.Controls.Add(this.theaterConfirm);
            this.theaterPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theaterPicker.Location = new System.Drawing.Point(0, 0);
            this.theaterPicker.Name = "theaterPicker";
            this.theaterPicker.Size = new System.Drawing.Size(962, 552);
            this.theaterPicker.TabIndex = 34;
            this.theaterPicker.Text = "panel9";
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(934, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 23);
            this.close.TabIndex = 35;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Theater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.theaterPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Theater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theater";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.theaterPicker.ResumeLayout(false);
            this.theaterPicker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox timeFrameCB;
        private System.Windows.Forms.ComboBox theaterCB;
        private AntdUI.ButtonShadow theaterConfirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private AntdUI.Panel theaterPicker;
        private AntdUI.Menu menu1;
        private AntdUI.Label close;
    }
}