using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"{LoggedUser.Username}'s Order History";

            lstHistory.Items.Clear();

            if (LoggedUser.History.Count == 0)
            {
                lstHistory.Items.Add("No orders have been made yet.");
                return;
            }

            foreach (string item in LoggedUser.History)
            {
                lstHistory.Items.Add(item);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Options option = new Options(LoggedUser);
            this.Hide();
            option.Show();
        }
    }
}
