using System;
using System.Windows.Forms;

namespace Cafe_OrderPoints_System
{
    public partial class History : Form
    {
        private User LoggedUser;

        public History(User user)
        {
            InitializeComponent();
            LoggedUser = user;
        }

        private void History_Load(object sender, EventArgs e)
        {
            lblTitle.Text = LoggedUser.Username + "'s Order History";

            lstHistory.Items.Clear();

            if (LoggedUser.OrderHistory == null || LoggedUser.OrderHistory.Count == 0)
            {
                lstHistory.Items.Add("No orders have been made yet.");
                return;
            }

            foreach (OrderRecord item in LoggedUser.OrderHistory)
            {
                lstHistory.Items.Add(item.ToString());
            }
        }
            private void btnBack_Click(object sender, EventArgs e)
        {
            Options form = new Options(LoggedUser);
            this.Hide();
            form.Show();
        }
    }
    }
