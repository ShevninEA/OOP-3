using System;

namespace OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount()
            {
                balance = 123,
                number = 777
            };
            BankAccount account2 = new BankAccount()
            {
                balance = 580,
                number = 111

            };

            account1.TransactionCoins(account2, 120);

            account1.Info();
            account2.Info();
        }
    }
}
