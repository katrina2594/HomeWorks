namespace Task_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число a > 0");
            string input1 = Console.ReadLine();
            Console.WriteLine("Введите целое число b > 0");
            string input2 = Console.ReadLine();
            int a = 0;
            int b = 0;
            if (int.TryParse(input1, out a) && a > 0 && int.TryParse(input2, out b) && b > 0)
            {
                int result = 1;
                for (int i = 1; i <= b; i++)
                {
                    result *= a;
                }
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine("Введите корректные числа");

            }
            Console.ReadKey();
        }
    }
}

            
    

