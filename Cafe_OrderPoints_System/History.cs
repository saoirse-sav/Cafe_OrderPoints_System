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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();

            foreach (OrderRecord record in LoggedUser.OrderHistory)
            {
                lstHistory.Items.Add(record.GetSummary());
            }

            if (LoggedUser.OrderHistory.Count == 0)
            {
                lstHistory.Items.Add("No order history found.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Options opt = new Options(LoggedUser);
            this.Hide();
            opt.Show();
        }
    }
}
