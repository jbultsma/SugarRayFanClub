using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PoSMidterm
{
    class MenuClass
    {
        Cart c = new Cart();
        Receipt r = new Receipt();
        Total t = new Total();

        public void Intro()
        {
            bool runAgain = true, endLoop = true;
            while (runAgain == true)
            {
                bool isBuyAgain = false;
                Console.WriteLine("Hello!, Welcome to the Sugar Ray Fan Club Merch Store!");
                Console.WriteLine("Here you can buy all things Sugar Ray");
                Console.WriteLine("It's pretty cool");
                Console.WriteLine("Below you can find a list of things to pay to fill all of your Sugar Ray needs!");
                Console.WriteLine();

                do
                {
                    c.DisplayMenu();
                    c.AddToCartDB(c.Products, c.ShoppingCart);
                    Console.Write("Would you like to buy another item? (y/n): ");
                    string input = Console.ReadLine().ToLower().Trim();
                     //Console.Clear();

                    if (input == "y")
                    {
                        Console.WriteLine();
                        isBuyAgain = true;
                    }
                    else
                    {
                        isBuyAgain = false;
                    }
                }
                while (isBuyAgain == true);

                c.DisplayShoppingCart(c.ShoppingCart);
                    
                Console.WriteLine();
                t.SetTotal(c.ShoppingCart);
                t.DisplayTotal();
                Console.WriteLine();

                r.PaymentMenu(t);

                Console.WriteLine("Would you like to make another transaction? (y/n)");
                while (endLoop == true)
                {
                    string answer2 = Console.ReadLine().ToLower().Trim();
                    if (answer2 == "n")
                    {
                        runAgain = false;
                        endLoop = false;
                    }
                    else if (answer2 =="y")
                    {
                        runAgain = true;
                        endLoop = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter (y/n)");
                    }
                }
            }
        }
    }
}
