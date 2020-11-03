using Database;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RulesEngineUI
{
    public class PaymentMethodViewer
    {
        IDataAccess database;
        public PaymentMethodViewer()
        {
            database = new DummyDatabase();
        }
        public void ListSavedPaymentMethods()
        {
            IEnumerable<PaymentInfo> paymentMethods = database.GetSavedPaymentMethods();

            Console.WriteLine("Choose a Payment Method: ");
            Console.WriteLine("================================================================");

            foreach (var paymentMethod in paymentMethods)
            {
                Console.WriteLine($"{paymentMethod.PaymentType.ToString()} - {paymentMethod.CardNumber}");
                Console.WriteLine($"Type {paymentMethod.Id} to choose this payment method\n\n");
            }

            Console.WriteLine("================================================================");
        }

        public PaymentInfo Get(int Id)
        {
            return database.GetSavedPaymentMethods().FirstOrDefault(p => p.Id == Id);
        }
    }
}
