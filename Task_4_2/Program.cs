namespace Task_4_2
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
                double result = 0;
                for (int i = 1; i <= n; i++)
                {
                    result += 1.0/i;
                }
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine("Введите корректное натуральное число");

            }
            Console.ReadKey();
        }
    }
}
