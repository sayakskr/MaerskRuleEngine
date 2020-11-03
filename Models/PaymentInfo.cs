using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class PaymentInfo
    {
        public int Id { get; set; }
        public PaymentType PaymentType { get; set; }
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public string Expiry { get; set; }
        public int CVV { get; set; }
        public double Amount { get; set; }
    }
}
