using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inventory_Management_System.Domain
{
    internal class Inventory
    {
        private List<Product> products; 
        public Inventory()
        {
            products = new List<Product>();
        }
        public void AddProduct(Product newProduct) 
        {
            products.Add(newProduct); 
        }

        public void ViewProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products in the inventory yet");
                Console.WriteLine();
                return;
            }
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString()); // Console.WriteLine(product);
                Console.WriteLine();
            }
        }
        public bool IsThere(string testName)
        {
            foreach (var product in products)
            {
                if (((product.Name).Trim()).Equals(testName, StringComparison.OrdinalIgnoreCase)) 
                {
                    return true;
                }
            }
            return false;
        }
        public bool EditProduct(string oldName, string newName, decimal newPrice, int newQuantity)
        {
            foreach (var product in products)
            {
                if ((product.Name).Equals(oldName.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                        product.Name = newName;
                        product.Price = newPrice;
                        product.Quantity = newQuantity;
                        return true;
                }
            }
            return false;
        }
    }
}
