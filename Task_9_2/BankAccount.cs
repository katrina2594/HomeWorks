using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_2
{
    class BankAccount
    {
        private decimal _balance;
        public static int TotalAccounts { get; private set; }
        readonly int AccountNumber;
        public decimal Balance { get; private set; }
        public BankAccount()
        {
            TotalAccounts++;
            Random rnd = new Random();
            AccountNumber = rnd.Next(1000, 9999);
            Console.WriteLine($"Создан новый счет #{AccountNumber}," +
                    $"\nтекущий баланс: {Balance} руб.");
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"На счет #{AccountNumber} поступило {amount} руб." +
                    $"\nтекущий баланс: {Balance} руб.");
        }
        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Со счета #{AccountNumber} успешно списано {amount} руб." +
                    $"\nтекущий баланс: {Balance} руб.");
            }
            else
            {
                throw new ArgumentException($"Суммы на счете #{AccountNumber} недостаточно для списания {amount} руб." +
                    $"\nтекущий баланс: {Balance} руб.");
            }
        }
    }
}
