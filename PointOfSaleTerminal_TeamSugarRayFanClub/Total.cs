using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class Total
    {
        public double subTotal { get; set; }
        public double taxPercent { get; }
        public double grandTotal { get; set; }
        public Total()
        {
            this.taxPercent = .06;
        }
        public double GetTax(double s)
        {
            double grandTotal = s * taxPercent;
            return grandTotal;
        }
    }
}
