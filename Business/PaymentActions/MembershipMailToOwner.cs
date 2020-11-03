using System;
using System.Collections.Generic;
using System.Text;
using Models;
using PaymentGatewayService;

namespace Business.PaymentActions
{
    public class MembershipMailToOwner : IPaymentAction
    {
        public bool PerformAction(Order order, PaymentStatus paymentStatus)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("An email has been sent to you regarding your membership");
            Console.WriteLine("----------------------------------------------------------------------");

            return true;
        }
    }
}
