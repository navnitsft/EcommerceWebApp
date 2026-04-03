using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        // For simplicity, we store password in plain text here.
        // In production, use proper password hashing.
        public string Password { get; set; }
        public string Phone { get; set; }
        public string BillingAddress { get; set; }
        public List<Order> Orders { get; set; }
    }
}
