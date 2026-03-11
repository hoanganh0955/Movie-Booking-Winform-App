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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        //string sdt;
        //string matkhau;
        //string email;

        //private void buttondangky1_Click(object sender, EventArgs e)
        //{

        //    //-----------------------------họ tên-----------------------------------
        //    string hoten = txttenKH.Text;

        //    if (hoten == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập tên khách hàng!");
        //        txttenKH.Focus();
        //        return;
        //    }
        //    foreach (char c in hoten)
        //    {
        //        if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
        //        {
        //            MessageBox.Show("Tên khách hàng chỉ được chứa chữ cái và khoảng trắng!");
        //            txttenKH.Focus();
        //            return;
        //        }
        //    }

        //    //-----------------------------email-----------------------------------

        //    string email = txtemail.Text;

        //    if (email == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập địa chỉ email!");
        //        txtemail.Focus();
        //        return;
        //    }
        //    if (!email.Contains("@") || !email.Contains("."))
        //    {
        //        MessageBox.Show("Địa chỉ email không hợp lệ! Vui lòng nhập lại.");
        //        txtemail.Focus();
        //        return;
        //    }

        //    //MessageBox.Show("Đăng ký thành công! Chào mừng " + hoten + " đến với cửa hàng của chúng tôi!");


        //    //----------------------năm sinh---------------------------------


        //    int namsinh = dtpnamsinh.Value.Year;
        //    int namhientai = DateTime.Now.Year;

        //    if (namsinh > namhientai)
        //    {
        //        MessageBox.Show("Năm sinh không hợp lệ! Vui lòng chọn lại.");
        //        dtpnamsinh.Focus();
        //        return;
        //    }
        //    //MessageBox.Show("Đăng ký thành công! Chào mừng " + hoten + " đến với cửa hàng của chúng tôi!");


        //    //--------------------------------- mật khẩu ---------------------------------

        //    if (txtmk.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập mật khẩu");
        //        txtmk.Focus();
        //        return;
        //    }



        //    //MessageBox.Show("Đăng ký thành công");

        //    //-----------------------------giới tính-----------------------------------
        //    string gioiTinh;
        //    if (rdoNam.Checked)
        //    {
        //        gioiTinh = "Nam";
        //    }
        //    else if (rdoNu.Checked)
        //    {
        //        gioiTinh = "Nữ";
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn giới tính");
        //        return;
        //    }
        //    { MessageBox.Show("Giới tính đã chọn: " + gioiTinh); }




        //    //-----------------------------lưu thông tin-----------------------------------
        //    this.email = txtemail.Text;
        //    this.sdt = txtsdt.Text;
        //    this.matkhau = txtmk.Text;

        //    MessageBox.Show("Đăng ký thành công");

        //}

        ////------------------------------sdt-----------------------------------
        //private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    // Chỉ cho phép nhập số và phím Backspace
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true; // Ngăn chặn ký tự không hợp lệ
        //        MessageBox.Show("Vui lòng chỉ nhập số vào trường Số điện thoại!");
        //    }
        //}

        //private void btndangky_Click(object sender, EventArgs e)
        //{
        //    panel3.Visible = true;
        //    panel4.Visible = false;
        //}

        //private void btndangnhap_Click(object sender, EventArgs e)
        //{
        //    panel4.Visible = true;
        //    panel4.BringToFront();
        //    panel3.Visible = false;
        //}

        //private void lblemail1_Click(object sender, EventArgs e)
        //{

        //}

        //private void label4_Click(object sender, EventArgs e)
        //{

        //}

        //private void btndangnhap1_Click(object sender, EventArgs e)
        //{
        //    string user = txtDangNhap.Text;
        //    string pass = txtMatKhau.Text;

        //    if ((user == email || user == sdt) && pass == matkhau)
        //    {
        //        MessageBox.Show("Đăng nhập thành công! Chào mừng " + user + " đến với cửa hàng của chúng tôi!");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại thông tin đăng nhập.");
        //    }
        //}

        private void checkPass_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
