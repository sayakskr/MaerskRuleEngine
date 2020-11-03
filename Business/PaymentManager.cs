using Models;
using PaymentGatewayInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class PaymentManager
    {
        public static bool ProcessPayment(Order order, PaymentInfo paymentInfo, IPaymentGatewayService paymentGateway)
        {
            if (order != null && order.Product != null)
            {
                PaymentStatus paymentStatus;
                if (paymentGateway.ProcessPayment(paymentInfo, out paymentStatus))
                {
                    IEnumerable<IPaymentAction> actions = PaymentActionFactory.Get(order.Product.ProductType);

                    foreach (var action in actions)
                    {
                        action.PerformAction(order, paymentStatus);
                    }
                }
            }

            return true;
        }
    }
}
