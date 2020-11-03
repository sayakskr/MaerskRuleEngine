using System;
using System.Collections.Generic;
using System.Text;
using Models;
using PaymentGatewayService;

namespace Business.PaymentActions
{
    public class GenerateDuplicatePackingSlip : IPaymentAction
    {
        public bool PerformAction(Order order, PaymentStatus paymentStatus)
        {
            // Generate a packing slip

            Console.WriteLine("======================================================================");
            Console.WriteLine($"DUPLICATE PACKING SLIP FOR ROYALTIES : ORDER {order.OrderId}");
            Console.WriteLine("======================================================================");

            Console.WriteLine($"Order Id: \t{order.OrderId}");
            Console.WriteLine($"Produt Name: \t{order?.Product?.Name}");
            Console.WriteLine($"Product Description: \t{order?.Product?.Description}");
            Console.WriteLine($"Quantity: {order.Quantity}");

            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine(paymentStatus.Success ? "Payment Successful" : "Payment Failed");
            Console.WriteLine($"Transaction Amount: {paymentStatus.Amount}");
            Console.WriteLine($"Transaction ID: {paymentStatus.TransactionId}");

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------");

            return true;
        }
    }
}
