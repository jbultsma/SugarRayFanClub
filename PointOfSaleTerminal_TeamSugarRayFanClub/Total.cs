using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class Total
    {
        public double subTotal { get; set; }
        public double tax { get; set;  }
        public double grandTotal { get; set; }
        public Total()
        {
            //this.subtotal = subtotal;
            //this.tax = subtotal * .06;
            //this.grandtotal = tax + subtotal;
        }
        public void SetTotal(List<Product> x)
        {
            foreach(Product p in x)
            {
                subTotal = subTotal + (p.Price * p.Quantity);
            }
            tax = subTotal * .06;
            grandTotal = tax + subTotal;
        }
        public void DisplayTotal(Total t)
        {
            Console.WriteLine("Subtotal: " + t.subTotal);
            Console.WriteLine("Tax: " + t.tax);
            Console.WriteLine("Grand Total: " + t.grandTotal);
        }
    }
}
