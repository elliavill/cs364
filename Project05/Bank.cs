using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project05
{
   class Bank
   {
      private string bankName;
      private string bankAddress;
      private string bankPhoneNumber;
      private List<Customer> customerList;

      // Constructors
      public Bank(string Name, string Address, string PhoneNumber)
      {
         this.bankName = Name;
         this.bankAddress = Address;
         this.bankPhoneNumber = PhoneNumber;
         customerList = new List<Customer>();
      }

      // Properties
      public string Name
      {
         get { return bankName; }
         set { bankName = value; }
      }

      public string Address
      {
         get { return bankAddress; }
         set { bankAddress = value; }
      }

      public string PhoneNumber
      {
         get { return bankPhoneNumber; }
         set { bankPhoneNumber = value; }
      }

      public List<Customer> CustomerList
      {
         get { return customerList; }
         set { customerList = value; }
      }

      public void addCustomer(Customer cust)
      {
         customerList.Add(cust);
         return;
      }

      public override string ToString()
      {
         return "Bank: " + bankName + " " + bankAddress + " " + bankPhoneNumber + " " + customerList;
      }
   }
}

/*the class
 * 
 * 
 * Public Class Options
{
        private string id;
        private int option;

        public int ID
        {
            get { return id; }
            set { id= value; }
        }

        public string Option
        {
            get { return option; }
            set { option = value; }
        }
}


* public class Users

      {
        private int userId;
        private string pass;
        private List<Options> userOptions = new List<Options>();


        public int ID
        {
            get { return userId; }
            set { user = userId; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public List<Options> OptionsList
        {
            get { return userOptions; }
            set { userOptions = value; }
        }
      }


 * Users newUser = new Users ();
   Options userOption = new Options ();

   userOption.ID = int.Parse(txtBxID.Text);
   userOption.Option = txtBxOption.Text;

    Item.Options.Add(userOption);
 */