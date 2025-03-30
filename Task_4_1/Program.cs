using System.Security.Claims;

namespace Task_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            string input = Console.ReadLine();
            int n = 0;
            if (int.TryParse(input, out n) && n > 0)
            {
                int f = 1;
                for (int i = 1; i <= n; i++)
                {
                    f *= i;
                }
                Console.WriteLine(f);

            }
            else
            {
                Console.WriteLine("Введите корректное натуральное число");

            }
            Console.ReadKey();
        }
    }
}
