using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class Database
    {
        public List<Product> Cart = new List<Product>();
        public List<Product> History = new List<Product>();
        public List<Product> Products = new List<Product>();

        Product Vinyl1 = new Product("Floored", "Vinyl", "Sugar Ray's hit release from 1997", 30);
        Product Vinyl2 = new Product("Lemonade and Brownies", "Vinyl", "Sugar Ray's release from 1995. Probably isn't that good.", 30);
        Product Vinyl3 = new Product("14:59", "Vinyl", "Sugar Ray's most popular release from 1999. That was a good year", 30);
        Product Vinyl4 = new Product("Greatest Hits", "Vinyl", "The best of Sugar Ray on one album!!!", 35);
        Product Dvd = new Product("Scooby Doo The Movie", "DVD", "Sugar Ray makes a star apperance in this movie", 20);
        Product HairGel = new Product("Hair Gel", "Cosmetic Product", "Thick gel perfect for spiking hair. Recomended for frosted tips.", 3.5);
        Product Tshirt1 = new Product("T-Shirt", "Merchandise", "Collectable T-Shirt that will probably be worth and exponential amount in a decade.", 12);
        Product Tshirt2 = new Product("T-Shirt", "Merchandise", "A less desirable design of T-Shirt. Won't be worth anything in a few years", 12);
        Product LongSleeve = new Product("Long Sleeve", "Merchandise", "A long sleeve shirt with Sugar Ray's logo. No one wears long sleeves so they're on sale.", 10);
        Product Mug = new Product("Coffee Mug", "Merchandise", "The perfect vessle for a warm beverage", 5.5);
        Product SunGlasses = new Product("Sun Glasses", "Merchandise", "Helps block UV rays from your eyes and makes you look cool.", 10);
        Product SunScreen = new Product("Sun Screen", "Merchandise", "Bannana Boat brand SPF 50", 10);
        
        public Database()
        {
            Products.Add(Vinyl1);
            Products.Add(Vinyl2);
            Products.Add(Vinyl3);
            Products.Add(Vinyl4);
            Products.Add(Dvd);
            Products.Add(Tshirt1);
            Products.Add(Tshirt2);
            Products.Add(LongSleeve);
            Products.Add(Mug);
            Products.Add(HairGel);
            Products.Add(SunGlasses);
            Products.Add(SunScreen);
        }
        public void GetList()
        {
            int i = 1;
            for (int j = 0; j < Products.Count; j++)
            {
                Console.WriteLine(j + 1 + ") " + Products[j].Name + "\t" + Products[j].Price);
                Console.WriteLine();
                i++;
            }
        }

        public void AddToCart(int i)
        {
            // note, i will be the answer for Console.ReadLine() "What would you like to buy"?
            i--;
            Cart.Add(Products[i]);
            int dex = Cart.IndexOf(Products[i]);

            // The next three lines add to the Quantity property.
            Console.WriteLine("How many would you like?");
            int q = int.Parse(Console.ReadLine());
            Cart[dex].Quantity = q;
        }

        // This method is used to move Cart to history after transaction.
        public void MoveToHistory()
        {
            int i = 0;
            foreach(Product p in Cart)
            {
                History.Add(Cart[i]);
                Cart.Remove(p);
                i++;
            }
        }
    }
}
