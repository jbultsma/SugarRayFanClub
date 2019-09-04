using System;
using System.Collections.Generic;
using System.Text;

namespace PoSMidterm
{
    class Product
    {
        // Create properties for products
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product()
        {

        }

        public Product(string name, string category, string description, double price)
        {
            this.Name = name;
            this.Category = category;
            this.Description = description;
            this.Price = price;
            this.Quantity = 0;
        }
    }
}
