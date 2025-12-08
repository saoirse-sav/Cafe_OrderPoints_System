using System;
using System.Windows.Forms;

namespace Cafe_OrderPoints_System
{
    public partial class Options : Form
    {
        private User LoggedUser;

        public Options(User user)
        {
            InitializeComponent();
            LoggedUser = user;
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            OrderForm order = new OrderForm(LoggedUser);
            this.Hide();
            order.Show();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            this.Hide();
            signup.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
       
            History history = new History(LoggedUser);
            this.Hide();
            history.Show();
        }

        

        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
