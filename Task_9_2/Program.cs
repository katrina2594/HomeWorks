namespace Task_9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
            account1.Deposit(1000);
            BankAccount account2 = new BankAccount();
            account2.Deposit(2000);
            try
            {
                account1.Withdraw(500);
                account2.Withdraw(300);
                account1.Withdraw(1500);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.WriteLine($"Кол-во счетов: {BankAccount.TotalAccounts}");
            Console.ReadKey();
        }
    }
}
