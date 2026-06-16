using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_System
{
    internal class CurrentAccount:Account
    {
        public double overdraftlimit { get; set; } = 5000;
        public override void Withdraw(double amount)
        {
            if (Balance+overdraftlimit >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Amount Withdrawn : {amount}");
                Console.WriteLine($"Current Balance : {Balance}");
            }
            else
            {
                Console.WriteLine("Overdraft limit exceeded.");
            }
        }
    }
}
