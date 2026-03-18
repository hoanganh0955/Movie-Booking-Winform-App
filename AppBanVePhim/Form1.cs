using System;
using System.Windows.Forms;

namespace AppBanVePhim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            password.PasswordChar = '•';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SharedData.LoadFromJson();
        }

        public void ResetLogin()
        {
            username.Text = "";
            password.Text = "";
            username.Focus(); // focus vào ô username
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text) ||
                string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserAccount user = SharedData.LoadUser(username.Text.Trim());

            if (user == null)
            {
                MessageBox.Show("Tên người dùng không tồn tại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (user.Password != password.Text)
            {
                MessageBox.Show("Mật khẩu không đúng!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SharedData.CurrentUser = user;
            SharedData.LoadFromJson();

            MessageBox.Show($"Chào mừng {user.FullName}!", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Movie movieForm = new Movie();
            movieForm.Show();
            this.Hide();
        }

        private void showPass_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            password.PasswordChar = showPass.Checked ? '\0' : '•';
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.FormClosed += (s, args) => this.Show(); // ← hiện lại Form1 khi SignUp đóng
            signUpForm.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}