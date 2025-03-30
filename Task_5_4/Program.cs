namespace Task_5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[n];
            int[] t1 = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(0, 11);
                Console.Write("{0} ", t[i]);
                t1[n - 1 - i] = t[i];
            }
            Console.WriteLine();
            Console.WriteLine("Перевернутый массив:");
            foreach (int a in t1)
            {
                Console.Write("{0} ", a);
            }
            Console.ReadKey();

        }
    }
}
