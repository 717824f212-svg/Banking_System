using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_System
{
    internal class SavingsAccount:Account
    {
        public double minimumbalance { get; set; } = 1000;
        public override void Withdraw(double amount)
        {
            if (Balance-amount >=minimumbalance)
            {
                Balance -= amount;
                Console.WriteLine($"Amount Withdrawn : {amount}");
                Console.WriteLine($"Remaining Balance : {Balance}");
            }
            else
            {
                Console.WriteLine("Minimum balance must be maintained.");
            }
    }
}
}
