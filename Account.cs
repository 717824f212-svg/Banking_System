using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_System
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited Amount : {amount}");
            Console.WriteLine($"Current Balance : {Balance}");
        }

        public virtual void Withdraw(double amount)
        {
            Console.WriteLine("Withdraw Method");
        }
    }
}

