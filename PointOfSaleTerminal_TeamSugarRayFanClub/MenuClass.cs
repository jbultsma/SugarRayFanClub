using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class MenuClass
    {
        static void MainMenu()
        {
            bool isBuyAgain = false;
            Console.WriteLine("Hello!, Welcome to the Sugar Ray Fan Club Merch Store!");
            Console.WriteLine("Here you can buy all things Sugar Ray");
            Console.WriteLine("It's pretty cool");
            do
            {
                DisplayItems();
                PurchaseItems();
                PrintReceipt();
            }
            while (isBuyAgain == true);
        }

        static void DisplayItems()
        {
            Database database = new Database();
            Console.WriteLine("DisplayItems");

        }

        static void PurchaseItems()
        {
            Console.WriteLine("PurchaseItems");
        }

        static void PrintReceipt()
        {
            Console.WriteLine("PrintReceipt");
        }
       
    }
}
