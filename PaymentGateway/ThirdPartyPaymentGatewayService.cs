using Models;
using PaymentGatewayInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGatewayService
{
    public class ThirdPartyPaymentGatewayService : IPaymentGatewayService
    {
        static int traId = 137320;
        public bool ProcessPayment(PaymentInfo paymentInfo, out PaymentStatus paymentStatus)
        {
            // Connect to payment gateway
            // Process transaction
            // Get the transaction Id

            paymentStatus = new PaymentStatus
            {
                TransactionId = $"PYGWTRA{traId++}",
                Success = true,
                Amount = paymentInfo.Amount
            };
      
            return true;
        }
    }
}
