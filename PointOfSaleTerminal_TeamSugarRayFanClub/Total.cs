using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class Total
    {
        public double subTotal { get; set; }
        public double tax { get; }
        public double grandTotal { get; }

        public Total()
        {
        }
        public Total(double subtotal)
        {
            this.subTotal = subtotal;
            this.tax = subTotal * .06;
            this.grandTotal = tax + subTotal;
        }
        public void GetSubTotal(List<Product> prada)
        {
            // ENTER PROPER LIST OBJECT FROM CONSTRUCTOR LATER ON
            foreach(Product p in prada)
            {
                subTotal = subTotal + (p.Price * p.Quantity);
            }
        }
    }
}
