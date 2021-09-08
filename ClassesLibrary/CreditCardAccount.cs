using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        //fields

        //props
        public int AccountNumber { get; set; }
        public Customer CustomerInfo { get; set; }
        public decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualInterestRate { get; set; }

        //ctors
        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = IsPastDue;
            AnnualInterestRate = annualInterestRate;
        }

        public CreditCardAccount()
        {

        }

        //methods
        public override string ToString()
        {
            //return base.ToString();
            return $"\nAccount Number: {AccountNumber}\n" +
                $"Customer Info: {CustomerInfo}\n" +
                $"Balance: {Balance}\n" +
                $"Past Due? {IsPastDue}\n" +
                $"Annual Interest Rate: {AnnualInterestRate}";
        }

    }//end class
}//end namespace
