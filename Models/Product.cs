﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }
        public double Price { get; set; }
    }
}
