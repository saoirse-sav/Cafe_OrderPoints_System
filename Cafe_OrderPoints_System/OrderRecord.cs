using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_OrderPoints_System
{
    internal class OrderRecord
    {
        public string Drink { get; set; }
        public string Temperature { get; set; }
        public int DrinkQty { get; set; }

        public string Snack { get; set; }
        public int SnackQty { get; set; }

        public DateTime Date { get; set; }

        public OrderRecord(string drink, string temp, int drinkQty, string snack, int snackQty, DateTime date)
        {
            Drink = drink;
            Temperature = temp;
            DrinkQty = drinkQty;
            Snack = snack;
            SnackQty = snackQty;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Date:g} | Drink: {Drink} ({Temperature}) x{DrinkQty} | Snack: {Snack} x{SnackQty}";
        }
    
    }
}
