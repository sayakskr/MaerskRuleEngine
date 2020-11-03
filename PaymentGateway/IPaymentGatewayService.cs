using Models;
using PaymentGatewayService;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGatewayInterface
{
    public interface IPaymentGatewayService
    {
        bool ProcessPayment(PaymentInfo paymentInfo, out PaymentStatus paymentStatus);
    }
}
