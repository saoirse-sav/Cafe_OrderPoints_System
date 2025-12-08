using System;
using System.Collections.Generic;

namespace Cafe_OrderPoints_System
{
    public class OrderRecord
    {
        public string Drink { get; set; }
        public string Temperature { get; set; }
        public int DrinkQty { get; set; }

        public string Snack { get; set; }
        public int SnackQty { get; set; }

        public DateTime Date { get; set; }
        public int ClaimNumber { get; set; }
        public double TotalPrice { get; set; }


        public static List<OrderRecord> History = new List<OrderRecord>();

      
        public OrderRecord(
            string drink,
            string temperature,
            int drinkQty,
            string snack,
            int snackQty,
            DateTime date,
            int claimNumber,
            double totalPrice)
        {
            Drink = drink;
            Temperature = temperature;
            DrinkQty = drinkQty;
            Snack = snack;
            SnackQty = snackQty;
            Date = date;
            ClaimNumber = claimNumber;
            TotalPrice = totalPrice;
        }

       
        public string GetSummary()
        {
            return $"{Date} - #{ClaimNumber} | Drink: {Drink} x{DrinkQty} ({Temperature}) | Snack: {Snack} x{SnackQty} | Total: ₱{TotalPrice}";
        }
    }
}
