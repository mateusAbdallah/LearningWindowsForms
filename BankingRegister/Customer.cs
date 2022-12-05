using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingRegister
{
    internal class Customer
    {
        private string firstName;
        private string lastName;
        private int accountNumber;
        private double accountBalance;

        public Customer() { }

        public Customer(string first, string last, int account, double balance)
        {
            firstName = first;
            lastName = last;
            accountNumber = account;
            accountBalance = balance;
        }

        public string FirstName 
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }           
        }

        public double AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }            
        }

        public double Deposit(double amount)
        {
            double currency = 0.0;
            
            if(amount < 0 || amount == 0)
            {
                Console.WriteLine("Just value greater than 0");
            }
            else 
            {
                currency += amount;
            }

            return currency;
        }

        public double Withdraw(double amount)
        {
            double currency = 0.0;

            if(amount < 0 || amount == 0)
            {
                Console.WriteLine("Value does not exist");
            }
            else
            {
                currency -= amount;
            }

            return currency;
        }

        //public override string ToString()
        //{
        //    return "Successful Transaction";
        //}

    }
}
