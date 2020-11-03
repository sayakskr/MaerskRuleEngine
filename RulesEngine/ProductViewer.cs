using Database;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RulesEngineUI
{
    public class ProductViewer
    {
        IDataAccess database;
        public ProductViewer()
        {
            database = new DummyDatabase();
        }
        public void ListAllProducts()
        {
            IEnumerable<Product> products = database.GetProducts();

            Console.WriteLine("Choose a product: ");
            Console.WriteLine("================================================================");

            foreach(var product in products)
            {
                Console.WriteLine($"{product.Name} | {product.Description} | Rs. {product.Price}");
                Console.WriteLine($"Type {product.ProductId} to choose this product\n\n");
            }

            Console.WriteLine("================================================================");
        }

        public Product Get(int ProductId)
        {
            return database.GetProducts().FirstOrDefault(p => p.ProductId == ProductId);
        }
    }
}
