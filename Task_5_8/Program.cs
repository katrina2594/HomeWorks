namespace Task_5_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[] t = new int[n];
            Random rnd = new Random();
            int max1 = t[0];
            int max2 = t[0];
            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(0, 11);
                Console.Write("{0} ", t[i]);
                if (t[i] > max1)
                {
                    max1 = t[i];
                }
                else
                {
                    if (t[i] > max2)
                    {
                        max2 = t[i];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Маx1 {0}, Мax2 {1} ", max1, max2);
            Console.ReadKey();
        }
    }
}
          