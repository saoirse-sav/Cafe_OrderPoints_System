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

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cafe_OrderPoints_System
{
    public partial class OrderForm : Form
    {
        private User LoggedUser;
        private bool hasFreeOrder = false;

        // Price lists (in pesos)
        Dictionary<string, int> drinkPrices = new Dictionary<string, int>()
        {
            { "Americano Latte", 95 },
            { "Mocha", 145 },
            { "Spanish Latte", 150 },
            { "Vietnamese Latte", 150 },
            { "Macchiato", 155 }
        };

        Dictionary<string, int> snackPrices = new Dictionary<string, int>()
        {
            { "Chocolate chip cookies", 75 },
            { "Croissant", 85 },
            { "Waffles", 110 },
            { "Corndog", 65 },
            { "Crunchy pan", 40 }
        };

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
            if (cmbDrink.SelectedIndex == -1 && cmbSnack.SelectedIndex == -1)
            {
                MessageBox.Show("The form is empty. Please make an order or log out.");
                return;
            }

            // FREE ORDER CHECK
            bool isFreeOrder = false;
            if (LoggedUser.Points >= 10)
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

            // POINTS SYSTEM
            if (!isFreeOrder)
            {
                if (drink != "None")
                    LoggedUser.Points++;

                if (snack != "None")
                    LoggedUser.Points++;
            }

            // PRICE CALCULATION
            int drinkTotal = 0;
            int snackTotal = 0;

            if (!isFreeOrder)
            {
                if (drink != "None")
                    drinkTotal = drinkPrices[drink] * drinkQty;

                if (snack != "None")
                    snackTotal = snackPrices[snack] * snackQty;
            }

            int totalPrice = isFreeOrder ? 0 : (drinkTotal + snackTotal);

            // CLAIM NUMBER
            Random rnd = new Random();
            int claimNumber = rnd.Next(0, 300);

            // SUMMARY MESSAGE
            string message = $"ORDER SUMMARY\n\n" +
                             $"Drink: {drink}\n" +
                             $"Temperature: {temp}\n" +
                             $"Drink Qty: {drinkQty}\n\n" +
                             $"Snack: {snack}\n" +
                             $"Snack Qty: {snackQty}\n\n" +
                             $"Total Price: ₱{totalPrice}\n" +
                             $"Points Now: {LoggedUser.Points}\n" +
                             $"\nClaim Number: {claimNumber}\n";

            if (LoggedUser.Points >= 15)
                message += "\nYou have reached 15 points! Your next order will be FREE.\n";

            if (isFreeOrder)
                message += "\nThis order is FREE because you reached 15 points!\n";

            MessageBox.Show(message);

            
            LoggedUser.OrderHistory.Add(
                new OrderRecord(drink, temp, drinkQty, snack, snackQty, DateTime.Now, claimNumber, totalPrice)
            );
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn auth = new LogIn();
            auth.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Options optionForm = new Options(LoggedUser);
            this.Hide();
            optionForm.Show();
        }
    }
}

