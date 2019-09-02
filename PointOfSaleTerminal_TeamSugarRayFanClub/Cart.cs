using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class Cart
    {
        public Cart()
        {
            // This class is going to store two lists. One for the present items in the cart and one for the past purchases.
        }

        public double GetSubTotal()
        {
        }

        public void DisplayCartHistory()
        {
            
            foreach(Product p in Database.History)
            {
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Quantity);
            }
        }
    }
}
