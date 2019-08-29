using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class Total
    {
        public double subTotal { get; set; }
        public double salesTax { get; }
        public double grandTotal { get; set; }
        public Total()
        {
            this.salesTax = .06;
        }
        public double GetTax(double s)
        {
            double grandTotal = s * salesTax;
            return grandTotal;
        }
    }
}
