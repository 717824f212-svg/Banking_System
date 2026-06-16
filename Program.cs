namespace Banking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new SavingsAccount();

            acc1.AccountNumber = 101;
            acc1.AccountHolderName = "Vijay";
            acc1.Balance = 10000;

            acc1.Deposit(2000);
            acc1.Withdraw(9500);

            Console.WriteLine();

            Account acc2 = new CurrentAccount();

            acc2.AccountNumber = 102;
            acc2.AccountHolderName = "Kumar";
            acc2.Balance = 5000;

            acc2.Deposit(1000);
            acc2.Withdraw(9000);
        }
    }
}
