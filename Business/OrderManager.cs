using Models;
using PaymentGatewayInterface;
using PaymentGatewayService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public static class OrderManager
    {
        static IPaymentGatewayService paymentGateway;
        static int orderCounter = 1;
        static OrderManager()
        {
            paymentGateway = new ThirdPartyPaymentGatewayService();
        }
        public static bool PlaceOrder(Order order, PaymentInfo paymentInfo)
        {
            order.OrderId = orderCounter++;
            bool paymentSuccess = PaymentManager.ProcessPayment(order, paymentInfo, paymentGateway);
            if (paymentSuccess)
                order.Status = "Order successfully placed";
            else
                order.Status = "Order is pending. Payment failed";

            return paymentSuccess;
        }
    }
}
