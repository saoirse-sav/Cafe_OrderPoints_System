using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();  
        }
    }
}
