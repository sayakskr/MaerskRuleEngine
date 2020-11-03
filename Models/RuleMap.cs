using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class RuleMap
    {
        public RuleMap(string ProductType, string Action)
        {
            this.ProductType = ProductType;
            this.Action = Action;
        }
        public string ProductType { get; set; }
        public string Action { get; set; }
    }
}
