namespace Task_5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[n];
            int[] t1 = new int[n / 2];
            int[] t2 = new int[n / 2];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(-50, 51);
                Console.Write("{0} ", t[i]);
                if (i < n / 2)
                {
                    t1[i] = t[i];
                }
                else
                {
                    t2[i - n / 2] = t[i];
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2 - 1 - i; j++)
                {
                    if (t1[j] > t1[j + 1])
                    {
                        int a = t1[j];
                        t1[j] = t1[j + 1];
                        t1[j + 1] = a;

                    }

                }
            }
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2 - 1 - i; j++)
                {
                    if (t2[j] < t2[j + 1])
                    {
                        int a = t2[j];
                        t2[j] = t2[j + 1];
                        t2[j + 1] = a;
                    }

                }
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.Write("{0} ", t1[i]);
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write("{0} ",t2[i]);
            }
            Console.ReadKey();

        }
    }
}
