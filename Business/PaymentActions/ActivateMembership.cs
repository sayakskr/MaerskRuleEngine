using System;
using System.Collections.Generic;
using System.Text;
using Models;
using PaymentGatewayService;

namespace Business.PaymentActions
{
    public class ActivateMembership : IPaymentAction
    {
        public bool PerformAction(Order order, PaymentStatus paymentStatus)
        {
            // Activate the membership

            Console.WriteLine("======================================================================");
            Console.WriteLine($"MEMBERSHIP ACTIVATION NOTICE {order?.Product?.Name}");
            Console.WriteLine("======================================================================");

            Console.WriteLine($"Your membership has been activated successfully.");

            Console.WriteLine("----------------------------------------------------------------------");

            return true;
        }
    }
}
