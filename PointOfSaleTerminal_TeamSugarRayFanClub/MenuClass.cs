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

        }

        static void PurchaseItems()
        {

        }

        static void PrintReceipt()
        {

        }
       
    }
}
