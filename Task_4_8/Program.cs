namespace Task_4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string input = Console.ReadLine();
            int n = 0;

            if (int.TryParse(input, out n))
            {
                int s = Math.Abs(n);
                int result = 0;

                while (s > 0)
                {
                    int m = s % 10;
                    s = s / 10;
                    result = result * 10 + m;
                }
                Console.WriteLine("Обработанное число {0}", n > 0 ? result : -result);
            }

            else
            {
                Console.WriteLine("Некорректный ввод");

            }
            Console.ReadKey();
        }
    }
}
