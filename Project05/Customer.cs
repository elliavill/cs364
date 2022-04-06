using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project05
{
   class Customer
   {
      private string customerName;
      private string customerAddress;
      private string customerPhoneNumber;
      private List<Account> accountList;

      // Constructors
      public Customer(string Name, string Address, string PhoneNumber)
      {
         this.customerName = Name;
         this.customerAddress = Address;
         this.customerPhoneNumber = PhoneNumber;
         accountList = new List<Account>();
      }

      // Properties
      public string Name
      {
         get { return customerName; }
         set { customerName = value; }
      }

      public string Address
      {
         get { return customerAddress; }
         set { customerAddress = value; }
      }

      public string PhoneNumber
      {
         get { return customerPhoneNumber; }
         set { customerPhoneNumber = value; }
      }

      public List<Account> AccountList
      {
         get { return accountList; }
         set { accountList = value; }
      }

      public void addAccount(Account account)
      {
         accountList.Add(account);
         return;
      }

      public override string ToString()
      {
         return "Customer: " + customerName + " " + customerAddress + " " + customerPhoneNumber + " " + accountList;
      }
   }
}
