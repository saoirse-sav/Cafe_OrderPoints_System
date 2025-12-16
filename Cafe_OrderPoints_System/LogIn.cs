using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cafe_OrderPoints_System
{
    public partial class LogIn : Form
    {
        public static Dictionary<string, string> Users = new Dictionary<string, string>();
        public static Dictionary<string, string> Emails = new Dictionary<string, string>();

        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!Users.ContainsKey(username))
            {
                MessageBox.Show("Username doesn't exist.");
                return;
            }

            if (Users[username] != password)
            {
                MessageBox.Show("Incorrect password.");
                return;
            }

            MessageBox.Show("Login successful!");

            // Create actual User object
            User currentUser = new User(username, password);
            currentUser.Email = Emails[username];

            Options opt = new Options(currentUser);
            opt.Show();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignUp form = new SignUp();
            form.Show();
            this.Hide();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
