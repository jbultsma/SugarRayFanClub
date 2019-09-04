using System;
using System.Collections.Generic;
using System.Text;

namespace PoSMidterm
{
    class PaymentType
    {
        // Create properties for the additional information needed for each payment type
        public double CashValue { get; set; }
        public int CheckNumber { get; set; }
        public string CreditCardNum { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set; }
        public int CreditCardCVV { get; set; }

        public PaymentType()
        {

        }

        // Overload 1 for cash payment
        public PaymentType(double cashValue)
        {
            this.CashValue = cashValue;
        }

        // Overload 2 for check payment

        public PaymentType(int checkNumber)
        {
            this.CheckNumber = checkNumber;
        }

        // Overload 3 for credit card payment

        public PaymentType(string creditCardNum, string expiryMonth, string expiryYear, int creditCardCVV)
        {
            this.CreditCardNum = creditCardNum;
            this.ExpiryMonth = expiryMonth;
            this.ExpiryYear = expiryYear;
            this.CreditCardCVV = creditCardCVV;
        }
    }
}
