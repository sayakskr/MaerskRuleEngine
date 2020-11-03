using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public string Status { get; set; }
    }
}
