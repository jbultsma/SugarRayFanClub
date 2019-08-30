using System;
using System.Threading;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class Program
    {
        static void Main(string[] args)
        {
            Database Jimmy = new Database();
            Jimmy.Products[1].Quantity = 40;

            MenuClass menuClass = new MenuClass();

            menuClass.MainMenu();
            // figure out how to store cart. to redisplay on recipt during next purchase.

        }
    }
}
