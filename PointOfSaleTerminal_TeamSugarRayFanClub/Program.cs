using System;
using System.Threading;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class Program
    {
        static void Main(string[] args)
        {
            Database Data = new Database();
            MenuClass Menu = new MenuClass();
            Menu.MainMenu(Data);


            //Receipt r = new Receipt();
            //r.PaymentMenu();
        }
    }
}
