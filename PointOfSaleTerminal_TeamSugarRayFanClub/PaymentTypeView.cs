using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace PoSMidterm
{
    class PaymentTypeView
    {
        // Create instance of Payment Type to access properties & an instance of Total to access properties
        // public Total T = new Total();

        // Create a display method for each payment type
        public void DisplayCash(Total T)
        {
            Console.Write("\nEnter cash value to be tendered: ");
            double cashValue = double.Parse(Console.ReadLine());
            PaymentType pt = new PaymentType(cashValue);

            Console.WriteLine("\nPayment Type: Cash");

            Console.WriteLine("Cash Value Tendered: " + pt.CashValue.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Change: " + (pt.CashValue - T.GrandTotal).ToString("C", CultureInfo.CurrentCulture));
        }

        public void DisplayCheck(Total T)
        {
            Console.Write("\nPlease enter a check number: ");
            int checkNumber = int.Parse(Console.ReadLine());
            PaymentType pt = new PaymentType(checkNumber);
            Console.WriteLine("\nPayment Type: Check");
            Console.WriteLine("Check number: " + pt.CheckNumber);
            Console.WriteLine("Amount Tendered: " + T.GrandTotal.ToString("C", CultureInfo.CurrentCulture));
        }

        public void DisplayCreditCard(Total T)
        {
            Console.Write("\nPlease enter a credit card number: ");
            string creditCardNum = Console.ReadLine();
            Console.Write("Enter credit card expiration month (MM): ");
            string expiryMonth = Console.ReadLine();
            Console.Write("Enter credit card expiration year (YYYY): ");
            string expiryYear = Console.ReadLine();
            Console.Write("Enter credit card security code (CVV): ");
            int creditCardCVV = int.Parse(Console.ReadLine());
            PaymentType pt = new PaymentType(creditCardNum, expiryMonth, expiryYear, creditCardCVV);
            Console.WriteLine("\nPayment Type: Credit Card");
            Console.WriteLine("Credit Card Number: " + pt.CreditCardNum);
            Console.WriteLine("Credit Card Expiration Month/Year: " + pt.ExpiryMonth + "/" + pt.ExpiryYear);
            Console.WriteLine("Credit Card CVV: " + pt.CreditCardCVV);
            Console.WriteLine("Amount Tendered: " + T.GrandTotal.ToString("C", CultureInfo.CurrentCulture));
        }
    }
}
