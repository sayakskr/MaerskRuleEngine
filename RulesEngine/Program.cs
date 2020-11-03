using Business;
using Database;
using Models;
using PaymentGatewayInterface;
using PaymentGatewayService;
using RulesEngineUI;
using System;

namespace RulesEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductViewer productViewer = new ProductViewer();
            PaymentMethodViewer paymentMethodViewer = new PaymentMethodViewer();
            IPaymentGatewayService paymentGateway = new ThirdPartyPaymentGatewayService();

            productViewer.ListAllProducts();

            Console.WriteLine("Please enter product id: ");
            int productId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());
            Product product = productViewer.Get(productId);


            paymentMethodViewer.ListSavedPaymentMethods();
            Console.WriteLine("Please choose payment method: ");
            int paymentMethodId = Convert.ToInt32(Console.ReadLine());

            PaymentInfo paymentInfo = paymentMethodViewer.Get(paymentMethodId);
            paymentInfo.Amount = product.Price * qty;

            Order order = new Order
            {
                Product = product,
                Quantity = qty,
                TotalPrice = product.Price * qty
            };

            OrderManager.PlaceOrder(order, paymentInfo);

            Console.WriteLine("======================================================================");
            Console.WriteLine($"{order.Status}");
            Console.WriteLine("======================================================================");

            Console.ReadKey();
        }
    }
}
