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
    }
}
