namespace Task_5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[,] t = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0|| i % 2 != 0 && j % 2 != 0)
                    {
                        t[i, j] = 1;
                    }
                    else
                    {
                        t[i, j] = 0;
                    }
                    Console.Write("{0} ", t[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
