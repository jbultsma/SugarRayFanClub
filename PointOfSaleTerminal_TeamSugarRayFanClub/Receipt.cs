using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class Receipt
    {
        Total t = new Total();

        //public void PrintTotals() need parameter to use
        //{
        //    t.SetTotal();
        //}
        public void PaymentMenu()
        {
            Console.WriteLine("Select your payment type: ");
            Console.WriteLine("1.) Cash");
            Console.WriteLine("2.) Check");
            Console.WriteLine("3.) Credit Card");

            int input = int.Parse(Console.ReadLine());
            PaymentTypeView pv = new PaymentTypeView();
            if (input == 1)
            {
                pv.DisplayCash();
            }
            else if (input == 2)
            {
                pv.DisplayCheck();
            }
            else if (input == 3)
            {
                pv.DisplayCreditCard();
            }
        }
    }
}
