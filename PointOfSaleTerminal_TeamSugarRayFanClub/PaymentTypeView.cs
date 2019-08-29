using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class PaymentTypeView
    {
        // Create instance of Payment Type to access properties & an instance of Total to access properties
        //public PaymentType Pt = new PaymentType(67.00);
        public Total T = new Total();

        // Create a display method for each payment type
        public void DisplayCash()
        {
            Console.WriteLine("Enter cash value to be tendered: ");
            double cashValue = double.Parse(Console.ReadLine());
            PaymentType pt = new PaymentType(cashValue);
            Console.WriteLine("Payment Type: Cash");
            Console.WriteLine("Cash Value Tendered: " + pt.CashValue);
            Console.WriteLine("Change: " + (pt.CashValue - T.grandTotal));
        }

        public void DisplayCheck()
        {
            Console.WriteLine("Please enter a check number.");
            int checkNumber = int.Parse(Console.ReadLine());
            PaymentType pt = new PaymentType(checkNumber);
            Console.WriteLine("Payment Type: Check");
            Console.WriteLine("Check number: " + pt.CheckNumber);
            Console.WriteLine("Amount Tendered: " + T.grandTotal);
        }

        public void DisplayCreditCard()
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
            Console.WriteLine("Payment Type: Credit Card");
            Console.WriteLine("Credit Card Number: " + pt.CreditCardNum);
            Console.WriteLine("Credit Card Expiration Month: " + pt.ExpiryMonth);
            Console.WriteLine("Credit Card Expiration Year: " + pt.ExpiryYear);
            Console.WriteLine("Credit Card CVV: " + pt.CreditCardCVV);
            Console.WriteLine("Amount Tendered: " + T.grandTotal);
        }
    }
}
