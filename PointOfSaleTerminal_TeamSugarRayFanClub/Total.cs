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
        public Total(double subtotal)
        {
            this.subTotal = subtotal;
            this.tax = subTotal * .06;
            this.grandTotal = tax + subTotal;
        }

        /*
         * s for tax and grandtotal or if it was better to put them in the constructor.
         * 
        public double GetTax()
         * wasn't sure if I should build seperate model
        {
            return subTotal * taxPercent;
        }
        public double GetGrandTotal()
        {
            return GetTax() + subTotal;
        }
        */
    }
}
