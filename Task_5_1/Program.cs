namespace Task_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[n];
            Random rnd = new Random();
            int even = 0;
            int odd = 0;
            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(0, 101);
                Console.Write("{0} ", t[i]);
                if (t[i]%2==0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
                
            }
            Console.WriteLine();
            if (even > odd)
                Console.WriteLine("Количество четных чисел в массиве больше чем нечетных");
            else
            {
                if (even == odd)
                    Console.WriteLine("Количество нечетных чисел в массиве равно количеству четных");
                else
                    Console.WriteLine("Количество нечетных чисел в массиве больше чем четных");
            }
            Console.ReadKey();

        }
    }
}
