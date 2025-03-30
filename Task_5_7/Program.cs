namespace Task_5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            const int m = 5;
            int[,] t = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                int max = t[i, 0];
                for (int j = 0; j < m; j++)
                {
                    t[i, j] = random.Next(0, 11);
                    if (t[i, j] > max)
                    {
                        max = t[i, j];
                    }
                    Console.Write("{0,4} ", t[i, j]);
                }
                Console.WriteLine("Максимум: {0,4} ", max);
            }
            Console.ReadKey();
        }

    }
}

