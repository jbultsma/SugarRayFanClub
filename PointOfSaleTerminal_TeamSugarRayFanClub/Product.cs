using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public Product(string name, string category, string description, double price)
        {
            this.Name = name;
            this.Category = category;
            this.Description = description;
            this.Price = price;
        }

        public override string ToString()
        {
            return (this.Name + "\t\t\t\t" + this.Category); //+ "\t\t" + this.Description + "\t\t" + this.Price.ToString("C2", CultureInfo.CurrentCulture));
        }

    }
}
