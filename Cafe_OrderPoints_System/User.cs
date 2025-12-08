using System;
using System.Collections.Generic;

namespace Cafe_OrderPoints_System
{
    public class User
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Points { get; set; }
        public List<OrderRecord> OrderHistory { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            Points = 0;
            OrderHistory = new List<OrderRecord>();
        }
    }
}

