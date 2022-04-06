using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project05
{
   abstract class Account
   {
      // Fields
      private string  accountNumber;
      private decimal annualPercentageRate; // 0.1225 will be displayed as 12.25%

      public Account(string AccountNumber, decimal AnnualPercentageNumber)
      {
         accountNumber        = AccountNumber;
         annualPercentageRate = AnnualPercentageNumber;
      }

      // property
      public string AccountNumber
      {
         get { return accountNumber; }
      }

      public decimal AnnualPercentageNumber
      {
         get { return annualPercentageRate; }
         set { annualPercentageRate = value; }
      }

      public abstract decimal StartingBalance(decimal balance);
      public abstract decimal EndingBalance  (decimal balance);
      public virtual string   accountType()
      {
         return "Bank Account";
      }

      public override string ToString()
      {
         return "Account: " + accountNumber + " " + annualPercentageRate;
      }
   }

   /// <summary>
   /// DerivedClass
   /// </summary>
   class Checking : Account
   {
      // Fields
      private decimal balance;
      //private decimal credits;
      //private decimal debits;

      // Constructor, receives initial balance and uses it to initialize the instance variable
      public Checking(decimal balance, string accountNumber, decimal rate)
         :base(accountNumber, rate)
      {
         Balance = balance;
      }

      // Properties (validate initial balance)
      public decimal Balance
      {
         get { return balance; }
         set
         {
            if (value >= 0)
               balance = value;
            else
               throw new Exception("Balance cannot be negative.");
         }
      }

      // From Abstract Method, need to override
      public override decimal StartingBalance(decimal balance)
      {
         return balance;
      }
      public override decimal EndingBalance(decimal balance)
      {
         return balance;
      }

      public override string accountType()
      {
         return "Checking Account";
      }
   }

   class Saving : Account
   {
      private float balance;
      private float credits;
      private float debits;
      private float interestRate;
      public  const float INTEREST_RATE = 0.05F;

      public Saving(float accountBalance, float accountCredit, float accountDebits,
                     string accountNumber, decimal rate)
        : base(accountNumber, rate)
      {
         this.balance = accountBalance;
         this.credits = accountCredit;
         this.debits = accountDebits;
      }

      public void calculateInterest()
      {
         interestRate = balance * INTEREST_RATE;
      }

      public override decimal StartingBalance(decimal balance)
      {
         return balance;
      }
      public override decimal EndingBalance(decimal balance)
      {
         return balance;
      }
      public override string accountType()
      {
         return "Saving Account";
      }
   }

   class Loan : Account
   {
      private decimal principle;
      private decimal payments;

      public Loan(decimal Principle, decimal Payments,
                      string accountNumber, decimal rate)
         : base(accountNumber, rate)
      {
         this.principle = Principle;
         this.payments  = Payments;
      }

      public override decimal StartingBalance(decimal balance)
      {
         return balance;
      }
      public override decimal EndingBalance(decimal balance)
      {
         return balance;
      }
   }

   class Retirement : Account
   {
      private decimal balance;
      private decimal deposits;

      public Retirement(decimal Balance, decimal Deposits,
                      string accountNumber, decimal rate)
         : base(accountNumber, rate)
      {
         this.balance = Balance;
         this.deposits = Deposits;
      }

      public override decimal StartingBalance(decimal balance)
      {
         return balance;
      }
      public override decimal EndingBalance(decimal balance)
      {
         return balance;
      }

      /*
      public decimal calculateDeposit()
      {

      }

      public decimal endCycle()
      {
         
      }

      public override ToString()
      {
         // make it relevant to the account types and field available
         return "Checking Account";
      }
      */
   }

   /*
    * bb + dep - w * int = sigmaB
    * (interest rate)
    * interest rate/12 -- int/12 (goes to the account)
    * calculated field
    * make APR
    * can use constant for cycler per year
    * try catching exceptions
    * 
    * Create constructors that utilize the base class' constructors 
    * Pass up from the derived constructor, those fields that the base constructor will need (ex. account number and interest rate)
    * Create a sealed method that overrides the get method for the account type 
    * The ToString method should override the ToString from the Account class, for each of the derived classes.
    */
}
