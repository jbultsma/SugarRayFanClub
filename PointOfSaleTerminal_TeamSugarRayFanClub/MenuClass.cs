using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class MenuClass
    {
        public void MainMenu()
        {
            bool isBuyAgain = false;
            Console.WriteLine("Hello!, Welcome to the Sugar Ray Fan Club Merch Store!");
            //Console.Write("."); Thread.Sleep(1000); Console.Write("."); Thread.Sleep(1000); Console.WriteLine(".");
            Console.WriteLine("Here you can buy all things Sugar Ray");
            //Console.Write("."); Thread.Sleep(1000); Console.Write("."); Thread.Sleep(1000); Console.WriteLine(".");
            Console.WriteLine("It's pretty cool");
            //Console.Write("."); Thread.Sleep(1000); Console.Write("."); Thread.Sleep(1000); Console.WriteLine(".");
            Console.WriteLine("Below you can find a list of things to pay to fill all of your Sugar Ray needs!");
            //Console.Write("."); Thread.Sleep(1000); Console.Write("."); Thread.Sleep(1000); Console.WriteLine(".\n");
            Console.WriteLine();

            do
            {
                DisplayItems();
                AddToCart();
                Console.WriteLine("Would you like to buy another item? (y/n)" );
                string input = Console.ReadLine().ToLower().Trim();

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

        public void AddToCart()
        {
            Database d = new Database();
            Console.WriteLine("PurchaseItems");
            //Adding test code -Mari
            Console.WriteLine("What item would you like to purchase?");
            int purchaseInput = int.Parse(Console.ReadLine());
            d.AddToCart(purchaseInput - 1);
        }

        public void PrintReceipt()
        {
            Receipt c = new Receipt();
            c.PaymentMenu();
        }
       
    }
}
