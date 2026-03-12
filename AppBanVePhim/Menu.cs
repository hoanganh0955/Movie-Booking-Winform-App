using System;
using System.Windows.Forms;
using AntdUI;

namespace AppBanVePhim
{
    public static class MenuHandler
    {
        public static void HandleMenuSelect(MenuSelectEventArgs e, Form currentForm)
        {
            //MessageBox.Show("Item được chọn: " + e.Value.Name);

            switch (e.Value.Name)
            {
                case "menuMovie":
                    NavigateTo(new Movie(), currentForm);
                    break;

                case "menuPopcorn":
                    NavigateTo(new PopcornMenu(), currentForm);
                    break;

                case "menuBillings":
                    NavigateTo(new Billings(), currentForm);
                    break;

                case "menuRatings":
                    NavigateTo(new Ratings(), currentForm);
                    break;

                case "menuLogout":
                    Logout(currentForm);
                    break;
            }
        }

        // ─── Chuyển form ───
        private static void NavigateTo(Form targetForm, Form currentForm)
        {
            targetForm.Show();
            currentForm.Hide();
        }

        // ─── Đăng xuất ───
        private static void Logout(Form currentForm)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn đăng xuất không?",
                "Đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            SharedData.Logout();

            // Quay về Form1
            Form1 loginForm = Application.OpenForms["Form1"] as Form1;
            if (loginForm != null)
            {
                loginForm.ResetLogin();
                loginForm.Show();
            }
            else
            {
                new Form1().Show();
            }

            currentForm.Close();
        }
    }
}
