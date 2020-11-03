using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public interface IDataAccess
    {
        IEnumerable<RuleMap> GetRuleMap();
        IEnumerable<Product> GetProducts();
        IEnumerable<PaymentInfo> GetSavedPaymentMethods();
    }
}
