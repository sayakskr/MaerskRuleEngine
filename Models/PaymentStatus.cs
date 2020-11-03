using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class PaymentStatus
    {
        public string TransactionId { get; set; }
        public bool Success { get; set; }
        public double Amount { get; set; }
    }
}
