using System;
using System.Threading;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class Program
    {
        static void Main(string[] args)
        {
            //build out the Cart.cs class and the ViewTotal.cs class
            Product Toy = new Product("Toy", "Toy", "Toy", 4);
            
            MenuClass menuClass = new MenuClass();

            menuClass.MainMenu();
        }
    }
}
