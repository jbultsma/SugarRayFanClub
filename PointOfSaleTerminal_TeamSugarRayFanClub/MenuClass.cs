using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class MenuClass
    {
        public void MainMenu()
        {
            bool isBuyAgain = false;
            Console.WriteLine("Hello!, Welcome to the Sugar Ray Fan Club Merch Store!");
            Console.WriteLine("Here you can buy all things Sugar Ray");
            Console.WriteLine("It's pretty cool");
            do
            {
                DisplayItems();
                PurchaseItems();
                Console.WriteLine("Would you like to buy another item? (y/n)" );
                string input = Console.ReadLine();

                if (input == "y")
                {
                    isBuyAgain = true;
                }

                else { isBuyAgain = false; }
            }
            while (isBuyAgain == true);
        }

        public void DisplayItems()
        {
            Database database = new Database();
            database.GetList();
        }

        public void PurchaseItems()
        {
            Console.WriteLine("PurchaseItems");
        }

        public void PrintReceipt()
        {
            Console.WriteLine("PrintReceipt");
        }
       
    }
}
