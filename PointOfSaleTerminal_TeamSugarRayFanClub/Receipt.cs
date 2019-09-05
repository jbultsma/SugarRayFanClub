﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PoSMidterm
{
    class Receipt
    {
        public void PaymentMenu(Total t)
        {
            Console.WriteLine("Payment Options");
            Console.WriteLine("-".PadRight(100, '-'));
            Console.WriteLine("1.) Cash");
            Console.WriteLine("2.) Check");
            Console.WriteLine("3.) Credit Card");
            Console.Write("\nPlease select your preffered method of payment (1-3): ");

            int input = int.Parse(Console.ReadLine());
            PaymentTypeView pv = new PaymentTypeView();
            if (input == 1)
            {
                pv.DisplayCash(t);
            }
            else if (input == 2)
            {
                pv.DisplayCheck(t);
            }
            else if (input == 3)
            {
                pv.DisplayCreditCard(t);
            }
            Console.WriteLine("-".PadRight(100, '-'));
        }
    }
}
