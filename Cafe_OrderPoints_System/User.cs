using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_OrderPoints_System
{
    public class User
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Points { get; set; }
        public List<OrderRecord> OrderHistory { get; set; } = new List<OrderRecord>();
    }
}
    
