using System;
using System.Collections.Generic;
using System.Text;

namespace PoSMidterm
{
    class Receipt
    {
        public void PaymentMenu(Total t)
        {
            Console.WriteLine("\nPayment Options:");
            Console.WriteLine("\t1.) Cash");
            Console.WriteLine("\t2.) Check");
            Console.WriteLine("\t3.) Credit Card");
            Console.Write("Please select your preffered method of payment: ");

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
        }
    }
}
