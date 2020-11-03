using Models;
using PaymentGatewayService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public interface IPaymentAction
    {
        bool PerformAction(Order order, PaymentStatus paymentStatus);
    }
}
