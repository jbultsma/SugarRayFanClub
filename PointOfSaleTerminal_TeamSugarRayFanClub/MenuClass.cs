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

        public void Intro()
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
                Console.WriteLine("Would you like to buy another item? (y/n)");
                string input = Console.ReadLine().ToLower().Trim();
                //Console.Clear();

                if (input == "y")
                {
                    isBuyAgain = true;
                }
                else
                {
                    isBuyAgain = false;
                    c.DisplayShoppingCart(c.ShoppingCart);
                }
            }
            while (isBuyAgain == true);

        }



    }
}
