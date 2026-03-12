using System;
using System.Windows.Forms;
using System.Linq;

namespace AppBanVePhim
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            password.PasswordChar = '•';
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ! Vui lòng nhập lại.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (txtPhone.Text.Length < 10 || !txtPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            if (password.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SharedData.IsUserExisted(username.Text.Trim()))
            {
                MessageBox.Show("Tên người dùng này đã tồn tại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SharedData.IsPhoneTaken(txtPhone.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại này đã được đăng ký!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ! Vui lòng nhập lại.");
                txtEmail.Focus();
                return;
            }

            if (SharedData.IsEmailTaken(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email này đã được đăng ký!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dateTimePicker.Value.Year > DateTime.Now.Year)
            {
                MessageBox.Show("Năm sinh không hợp lệ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string gender = "Không xác định";
            if (maleBtn.Checked) gender = "Nam";
            else if (femBtn.Checked) gender = "Nữ";

            UserAccount newUser = new UserAccount
            {
                FullName = username.Text.Trim(),
                BirthDate = dateTimePicker.Text,
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Password = password.Text,
                Gender = gender
            };

            SharedData.SaveUser(newUser);

            MessageBox.Show($"Đăng ký thành công!\nVui lòng đăng nhập.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPass_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            password.PasswordChar = showPass.Checked ? '\0' : '•';
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}