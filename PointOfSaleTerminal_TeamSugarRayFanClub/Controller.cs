using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class Controller
    {
        // Create PaymentMenu()
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
                Console.WriteLine("Enter cash value to be tendered: ");
                double cashvalue = double.Parse(Console.ReadLine());
                PaymentType pt = new PaymentType(cashvalue);
                pv.DisplayCash();
            }
            else if (input == 2)
            {
                Console.WriteLine("Please enter a check number.");
                int checkNumber = int.Parse(Console.ReadLine());
                PaymentType pt = new PaymentType(checkNumber);
                pv.DisplayCheck();
            }
            else if (input == 3)
            {
                Console.WriteLine("Please enter a credit card number.");
                string creditCardNum = Console.ReadLine();
                Console.WriteLine("Enter credit card expiration month (MM).");
                int expiryMonth = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter credit card expiration year (YYYY).");
                int expiryYear = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter credit card security code (CVV).");
                int creditCardCVV = int.Parse(Console.ReadLine());
                PaymentType pt = new PaymentType(creditCardNum, expiryMonth, expiryYear, creditCardCVV);
                pv.DisplayCreditCard();
            }
        }
    }
}
