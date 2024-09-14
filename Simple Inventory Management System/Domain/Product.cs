using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inventory_Management_System.Domain
{
    internal class Product
    {
        // properties
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        // the constructor 
        public Product(string name, decimal price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity; 
        }
        public override string ToString()
        {
            return $"- Product name : {Name}\n- Price: ${Price}\n- Quantity: {Quantity}"; 
        }
    }
}
