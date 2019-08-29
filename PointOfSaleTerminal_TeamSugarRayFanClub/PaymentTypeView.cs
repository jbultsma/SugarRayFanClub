using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSaleTerminal_TeamSugarRayFanClub
{
    class PaymentTypeView
    {
        // Create instance of Payment Type to access properties & an instance of Total to access properties
        public PaymentType pt = new PaymentType();
        public Total t = new Total();

        // Create a display method for each payment type
        public void DisplayCash()
        {
            Console.WriteLine("Payment Type: Cash");
            Console.WriteLine("Cash Value Tendered: " + pt.CashValue);
            Console.WriteLine("Change: " + (pt.CashValue - t.grandTotal));
        }

        public void DisplayCheck()
        {
            Console.WriteLine("Payment Type: Check");
            Console.WriteLine("Check number: " + pt.CheckNumber);
            Console.WriteLine("Amount Tendered: " + t.grandTotal);
        }

        public void DisplayCreditCard()
        {
            Console.WriteLine("Payment Type: Credit Card");
            Console.WriteLine("Credit Card Number: " + pt.CreditCardNum);
            Console.WriteLine("Credit Card Expiration Month: " + pt.ExpiryMonth);
            Console.WriteLine("Credit Card Expiration Year: " + pt.ExpiryYear);
            Console.WriteLine("Credit Card CVV: " + pt.CreditCardCVV);
            Console.WriteLine("Amount Tendered: " + t.grandTotal);
        }
    }
}
