using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PoSMidterm
{
    class Cart
    {
        public List<Product> Products = new List<Product>();
        public List<Product> ShoppingCart = new List<Product>();

        public Cart()
        {
            Products.Add(new Product("Floored", "Vinyl", "Sugar Ray's hit release from 1997", 30));
            Products.Add(new Product("Lemonade and Brownies", "Vinyl", "Sugar Ray's release from 1995. Probably isn't that good.", 30));
            Products.Add(new Product("14:59", "Vinyl", "Sugar Ray's most popular release from 1999. That was a good year", 30));
            Products.Add(new Product("Greatest Hits", "Vinyl", "The best of Sugar Ray on one album!!!", 35));
            Products.Add(new Product("Scooby Doo The Movie", "DVD", "Sugar Ray makes a star appearance in this movie", 20));
            Products.Add(new Product("Hair Gel", "Cosmetic Product", "Thick gel perfect for spiking hair. Recommended for frosted tips.", 3.5));
            Products.Add(new Product("T-Shirt", "Merchandise", "Collectable T-Shirt that will probably be worth and exponential amount in a decade.", 12));
            Products.Add(new Product("T-Shirt", "Merchandise", "A less desirable design of T-Shirt. Won't be worth anything in a few years", 12));
            Products.Add(new Product("Long Sleeve", "Merchandise", "A long sleeve shirt with Sugar Ray's logo. No one wears long sleeves so they're on sale.", 10));
            Products.Add(new Product("Coffee Mug", "Merchandise", "The perfect vessel for a warm beverage", 5.5));
            Products.Add(new Product("Sun Glasses", "Merchandise", "Helps block UV rays from your eyes and makes you look cool.", 10));
            Products.Add(new Product("Sun Screen", "Merchandise", "Banana Boat brand SPF 50", 10));
        }

        public void DisplayMenu()
        {
            int i = 1;
            for (int j = 0; j < Products.Count; j++)
            {
                Console.WriteLine((j + 1 + ") ").ToString().PadRight(4) + Products[j].Name.PadRight(25, '.') + Products[j].Price.ToString("C", CultureInfo.CurrentCulture).PadLeft(15, '.')); // Added dollar sign and formatting to clean it up -Mari
                i++;
            }
        }

        public void AddToCartDB(List<Product> Products, List<Product> ShoppingCart)
        {
            Console.WriteLine("What would you like to buy? (enter 1 - 12)");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: " + Products[index - 1].Name);
            Console.WriteLine("Category: " + Products[index - 1].Category);
            Console.WriteLine("Description: " + Products[index - 1].Description);
            Console.WriteLine("Price: " + Products[index - 1].Price.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine();

            while (true)
            {
            Console.WriteLine("You would like " + Products[index - 1].Name + "? (y/n)");
            string answer = Console.ReadLine().Trim().ToLower();
                if (answer == "y")
                {
                    Console.WriteLine("How many would you like?");
                    Products[index - 1].Quantity = int.Parse(Console.ReadLine());

                    ShoppingCart.Add(Products[index - 1]);
                    break;
                }
                else if (answer == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry I didn't understand that. Please answer again. (y/n)");
                }
            }
        }

        public void DisplayShoppingCart(List<Product> ShoppingCart)
        {
            Console.WriteLine("Items in cart: ");

            foreach (Product item in ShoppingCart)
            {
                Console.WriteLine("Name: " + item.Name.PadRight(25) + "Price: " + item.Price.ToString("C", CultureInfo.CurrentCulture).PadLeft(10).PadRight(25) + "Quantity: " + item.Quantity);
            }
        }
    }
}
