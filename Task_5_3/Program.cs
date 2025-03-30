namespace Task_5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[n];
            Random rnd = new Random();
            t[0]= rnd.Next(0, 51);
            Console.Write("{0} ", t[0]);
            int min = t[0];
            int max = t[0];
            int i1 = 0;
            int i2 = 0;
            for (int i = 1; i < n; i++)
            {
                t[i] = rnd.Next(0, 51);
                Console.Write("{0} ", t[i]);
                if (t[i] < min)
                {
                    min = t[i];
                    i1 = i;
                }
                if (t[i] > max)
                {
                    max = t[i];
                    i2 = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Максимальное число массива {0}, с индексом {1}, Минимальное число массива {2}, с индексом {3}", max, i2, min, i1);
            Console.ReadKey();
        }
    }
}
