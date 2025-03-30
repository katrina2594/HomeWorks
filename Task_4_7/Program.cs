namespace Task_4_7
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
                n = Math.Abs(n);
                if (n == 0)
                {
                    Console.WriteLine("Количество знаков в числе 1");
                }
                else
                {
                    int symbolsNumber = 0;
                    while (n > 0)
                    {
                        n = n / 10;
                        symbolsNumber++;
                    }
                    Console.WriteLine("Количество знаков в числе {0}", symbolsNumber);
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод");

            }
            Console.ReadKey();
        }
    }
}
