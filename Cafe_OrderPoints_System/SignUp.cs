using System;
using System.Windows.Forms;

namespace Cafe_OrderPoints_System
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirm = txtConfirm.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Password confirmation does not match.");
                return;
            }

            if (LogIn.Users.ContainsKey(username))
            {
                MessageBox.Show("Username is already taken.");
                return;
            }

            LogIn.Users.Add(username, password);
            LogIn.Emails.Add(username, email);

            MessageBox.Show("Account created!");

            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }
    }
}
