using System;
using System.Collections.Generic;
using System.Text;
using Models;
using PaymentGatewayService;

namespace Business.PaymentActions
{
    public class GenerateCommissionToAgent : IPaymentAction
    {
        public bool PerformAction(Order order, PaymentStatus paymentStatus)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("A 5% commission has been sent to your agent.");
            Console.WriteLine("----------------------------------------------------------------------");

            return true;
        }
    }
}
