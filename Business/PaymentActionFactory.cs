using Database;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public static class PaymentActionFactory
    {
        public static IEnumerable<IPaymentAction> Get(ProductType productType)
        {
            IDataAccess database = new DummyDatabase();
            var ruleMap = database.GetRuleMap();
            List<IPaymentAction> actions = new List<IPaymentAction>();

            foreach(var rule in ruleMap)
            {
                if (rule.ProductType == productType.ToString())
                {
                    Type t = Type.GetType($"Business.PaymentActions.{rule.Action}");
                    actions.Add((IPaymentAction)Activator.CreateInstance(t));
                }
            }

            return actions;
        }
    }
}
