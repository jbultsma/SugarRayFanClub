﻿using System;
using System.Threading;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("The Sugar Ray Fanclub!");

            //Console.WriteLine("\n...\n");
            //Thread.Sleep(300);

            //Run();

            Controller c = new Controller();
            c.PaymentMenu();
            
        }

        public static void Run()
        {
            MenuClass menuClass = new MenuClass();
        }
    }
}
