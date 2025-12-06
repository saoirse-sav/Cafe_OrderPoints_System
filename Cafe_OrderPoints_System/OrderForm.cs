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
    public partial class OrderForm : Form
    {
        private User LoggedUser; 
        private bool hasFreeOrder = false;

        public OrderForm(User user)
        {
            InitializeComponent();
            LoggedUser = user;

            LoadMenu();
        }

        private void LoadMenu()
        {
            // Drinks
            cmbDrink.Items.Add("Americano Latte");
            cmbDrink.Items.Add("Mocha");
            cmbDrink.Items.Add("Spanish Latte");
            cmbDrink.Items.Add("Vietnamese Latte");
            cmbDrink.Items.Add("Macchiato");

            // Snacks
            cmbSnack.Items.Add("Chocolate chip cookies");
            cmbSnack.Items.Add("Croissant");
            cmbSnack.Items.Add("Waffles");
            cmbSnack.Items.Add("Corndog");
            cmbSnack.Items.Add("Crunchy pan");

            // Temperature
            cmbTemp.Items.Add("Hot");
            cmbTemp.Items.Add("Cold");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            if (cmbDrink.SelectedIndex == -1 &&
                cmbSnack.SelectedIndex == -1)
            {
                MessageBox.Show("The form is empty. Please make an order or log out.");
                return;
            }

            // FREE ORDER CHECK
            bool isFreeOrder = false;
            if (LoggedUser.Points >= 50)
            {
                isFreeOrder = true;
                LoggedUser.Points = 0;
            }

            // GET ORDER DETAILS
            string drink = cmbDrink.SelectedIndex != -1 ? cmbDrink.SelectedItem.ToString() : "None";
            string snack = cmbSnack.SelectedIndex != -1 ? cmbSnack.SelectedItem.ToString() : "None";
            string temp = cmbTemp.SelectedIndex != -1 ? cmbTemp.SelectedItem.ToString() : "None";

            int drinkQty = (int)qtyDrinks.Value;
            int snackQty = (int)qtySnacks.Value;

            // ADD POINTS ONLY IF NOT FREE ORDER
            if (!isFreeOrder)
            {
                if (cmbDrink.SelectedIndex != -1)
                    LoggedUser.Points++;

                if (cmbSnack.SelectedIndex != -1)
                    LoggedUser.Points++;
            }


            string message = $"ORDER SUMMARY\n\n" +
                             $"Drink: {drink}\n" +
                             $"Temperature: {temp}\n" +
                             $"Drink Qty: {drinkQty}\n\n" +
                             $"Snack: {snack}\n" +
                             $"Snack Qty: {snackQty}\n\n" +
                             $"Current Points: {LoggedUser.Points}\n";


            if (LoggedUser.Points >= 50)
            {
                message += "\nYou have reached 50 points! Your next order will be FREE.\n";
            }

            if (isFreeOrder)
            {
                message += "\nThis order is FREE because you reached 50 points!\n";
            }

            MessageBox.Show(message);


            LoggedUser.OrderHistory.Add(
                new OrderRecord(drink, temp, drinkQty, snack, snackQty, DateTime.Now)
            );
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn auth = new LogIn();
            auth.Show();
        }
    }
}