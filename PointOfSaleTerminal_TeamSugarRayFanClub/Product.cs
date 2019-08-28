using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class Product
    {
        public string Name { get; set; }
        public string Catagory { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product(string name, string catagory, string description, double price)
        {
            this.Name = name;
            this.Catagory = catagory;
            this.Description = description;
            this.Price = price;
        }
    }
}
