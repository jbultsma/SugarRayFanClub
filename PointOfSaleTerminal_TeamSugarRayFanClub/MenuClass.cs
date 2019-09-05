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
            bool isRunAgain = true, isEndLoop = true;

            do
            {
                bool isBuyAgain = false;

                Console.WriteLine("Hello!, Welcome to the Sugar Ray Fan Club Merch Store!");
                Console.WriteLine("Here you can buy all things Sugar Ray");
                Console.WriteLine("It's pretty cool");
                Console.WriteLine("Below you can find a list of things to pay to fill all of your Sugar Ray needs!\n");

                do
                {
                    c.DisplayMenu();
                    c.AddToCartDB(c.Products, c.ShoppingCart);

                    bool isInvalidInput = true;

                    do
                    {
                        Console.Write("Would you like to add another item to your cart? (y/n): ");
                        string input = Console.ReadLine().ToLower().Trim();                        

                        if (input == "y")
                        {
                            Console.Clear();
                            Console.WriteLine();
                            isBuyAgain = true;
                            isInvalidInput = true;
                        }

                        else if (input == "n")
                        {
                            Console.Clear();
                            Console.WriteLine();
                            isBuyAgain = false;
                            isInvalidInput = true;
                        }

                        else
                        {
                            Console.WriteLine("Invalid input. Please try again.\n");
                            isInvalidInput = false;
                        }
                    } while (isInvalidInput == false);
                }   while (isBuyAgain == true);

                c.DisplayShoppingCart(c.ShoppingCart);

                Console.WriteLine();
                t.SetTotal(c.ShoppingCart);
                t.DisplayTotal();
                Console.WriteLine();

                r.PaymentMenu(t);

                do
                {
                    Console.Write("Would you like to make another transaction? (y/n): ");
                    string answer2 = Console.ReadLine().ToLower().Trim();

                    if (answer2 == "y")
                    {
                        isRunAgain = true;
                        isEndLoop = true;
                        Console.Clear();
                    }

                    else if (answer2 == "n")
                    {
                        isRunAgain = false;
                        isEndLoop = true;
                        Console.Clear();
                        Console.WriteLine("Thank you for shopping at the Sugar Ray Fan Club Merch Store!");
                        Console.WriteLine("\nYou have pleased Mark McGrath by your contribution.\n");
                    }

                    else
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                        isEndLoop = false;
                    }
                } while (isEndLoop == false);

            }   while (isRunAgain == true);
        }
    }
}
