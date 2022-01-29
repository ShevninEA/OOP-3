using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public enum TypeOfBankAccount
    {
        DEBIT,
        CREDIT,
        DEPOSIT
    }
    public class BankAccount
    {
        public int number { get; set; }
        public int balance { get; set; }
        private TypeOfBankAccount _typeAccount;
        private int summa = 0;

        public int TransactionCoins(BankAccount btn, int summa)
        {
            balance += summa;
            this.balance = balance;
            btn.balance -= summa;
            return balance;
        }
        public void Info()
        {
            Console.WriteLine($"Тип счёта: {_typeAccount}, Номер счёта: {number}, Баланс: {balance} $");
        }
    }
}
