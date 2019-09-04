using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class MenuClass
    {
        public void MainMenu(Database Data)
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
                DisplayItems(Data);
                AddToCart(Data);
                Console.WriteLine("Would you like to buy another item? (y/n)" );
                string input = Console.ReadLine().ToLower().Trim();

                if (input == "y")
                {
                    isBuyAgain = true;
                }
                else
                {
                    isBuyAgain = false;
                }
            }
            while (isBuyAgain == true);
        }

        public void DisplayItems(Database Data)
        {
            int i = 1;
            for (int j = 0; j < Data.Products.Count; j++)
            {
                Console.WriteLine(j + 1 + ") " + Data.Products[j].Name.PadRight(25) + "\t" + Data.Products[j].Price.ToString("C", CultureInfo.CurrentCulture).PadLeft(10)); // Added dollar sign and formatting to clean it up -Mari
                //Console.WriteLine(); // I think the menu looks better without this extra blank line -Mari
                i++;
            }
        }
        public void AddToCart(Database Data)
        {
            Console.WriteLine("What would you like to buy? (enter 1 - 12)");
            int i = int.Parse(Console.ReadLine());
            i--;

            Console.WriteLine("Name: " + Data.Products[i].Name);
            Console.WriteLine("Category: " + Data.Products[i].Category);
            Console.WriteLine("Description: " + Data.Products[i].Description);
            Console.WriteLine("Price: " + Data.Products[i].Price.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine();
            Console.WriteLine("You would like " + Data.Products[i].Name + "? (y/n)");

            while (true)
            {
              string answer = Console.ReadLine().Trim().ToLower();
                if (answer == "y")
                {
                    Data.Cart.Add(Data.Products[i]);
                    int dex = Data.Cart.IndexOf(Data.Products[i]);
                        
                    Console.WriteLine("How many would you like?");
                    int q = int.Parse(Console.ReadLine());
                    Data.Cart[dex].Quantity = q;
                    break;
                }
                else if (answer == "n")
                {
                    AddToCart(Data);
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry I didn't understand that. Please answer again. (y/n)");
                }
            }
        }
        public void PrintReceipt()
        {
            Receipt c = new Receipt();
            c.PaymentMenu();
        }      
    }
}
