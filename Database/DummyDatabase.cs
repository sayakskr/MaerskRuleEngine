using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Database
{
    public class DummyDatabase : IDataAccess
    {
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { ProductId = 1, Name = "Parker Ball Pen", Description = "Blue Ball Point Pen", ProductType = ProductType.PHYSICAL_PRODUCT, Price = 158 },
                new Product { ProductId = 2, Name = "The Monk Who Sold his Ferrari", Description = "Book by Robin Sharma", ProductType = ProductType.BOOK, Price = 350 },
                new Product { ProductId = 3, Name = "Netflix", Description = "1 month Netflix membership @ Rs. 649 PM", ProductType = ProductType.MEMBERSHIP, Price = 649 },
                new Product { ProductId = 4, Name = "Upgrade Netflix Membership", Description = "Renew Netflix membership @ Rs. 649 PM", ProductType = ProductType.MEMBERSHIP_UPGRADE, Price = 649 },
                new Product { ProductId = 5, Name = "Learning To Ski", Description = "Basic SKI Pack", ProductType = ProductType.LEARNING_TO_SKI, Price = 25000 },
            };
        }

        public IEnumerable<RuleMap> GetRuleMap()
        {
            return new List<RuleMap>()
            {
                new RuleMap("PHYSICAL_PRODUCT", "GeneratePackingSlip"),
                new RuleMap("BOOK", "GeneratePackingSlip"),
                new RuleMap("BOOK", "GenerateDuplicatePackingSlip"),
                new RuleMap("MEMBERSHIP", "GeneratePackingSlip"),
                new RuleMap("MEMBERSHIP", "ActivateMembership"),
                new RuleMap("MEMBERSHIP_UPGRADE", "GeneratePackingSlip"),
                new RuleMap("MEMBERSHIP_UPGRADE", "ApplyUpgrade"),
                new RuleMap("MEMBERSHIP", "MembershipMailToOwner"),
                new RuleMap("MEMBERSHIP_UPGRADE", "MembershipUpgradeMailToOwner"),
                new RuleMap("LEARNING_TO_SKI", "GeneratePackingSlipWithVideo"),
                new RuleMap("PHYSICAL_PRODUCT", "GenerateCommissionToAgent"),
                new RuleMap("BOOK", "GenerateCommissionToAgent"),
            };
        }

        public IEnumerable<PaymentInfo> GetSavedPaymentMethods()
        {
            return new List<PaymentInfo>
            {
                new PaymentInfo { Id = 1, PaymentType = PaymentType.CREDIT_CARD, CardNumber = "4567-XXXX-XXXX-XX98", Name = "CARDHOLDER", CVV = 111 },
                new PaymentInfo { Id = 2, PaymentType = PaymentType.DEBIT_CARD, CardNumber = "1234-XXXX-XXXX-X432", Name = "CARDHOLDER", CVV = 222 }
            };
        }
    }
}
