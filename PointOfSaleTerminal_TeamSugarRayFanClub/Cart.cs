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
        public void DisplayCartHistory(List<Product> hist)
        {           
            foreach(Product p in hist)
            {
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Quantity);
            }
        }
    }
}
