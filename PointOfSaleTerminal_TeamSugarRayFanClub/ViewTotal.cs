using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class ViewTotal
    {
        public void DisplayTotal(Total t)
        {           
            Console.WriteLine("Subtotal: " + t.subTotal);
            Console.WriteLine("Tax: " + t.tax);
            Console.WriteLine("Grand Total: " + t.grandTotal);
        }
    }
}
