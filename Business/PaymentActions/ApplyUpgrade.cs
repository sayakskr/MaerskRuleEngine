using System;
using System.Collections.Generic;
using System.Text;
using Models;
using PaymentGatewayService;

namespace Business.PaymentActions
{
    public class ApplyUpgrade : IPaymentAction
    {
        public bool PerformAction(Order order, PaymentStatus paymentStatus)
        {
            // Apply Upgrade

            Console.WriteLine("======================================================================");
            Console.WriteLine($"MEMBERSHIP UPGRADATION NOTICE {order?.Product?.Name}");
            Console.WriteLine("======================================================================");

            Console.WriteLine($"Your membership has been upgraded successfully");

            Console.WriteLine("----------------------------------------------------------------------");

            return true;
        }
    }
}
