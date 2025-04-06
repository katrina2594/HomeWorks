namespace Task_7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] m = { 1, 2, 3, 4, 5, 6 };
            PrintNumbers(m, true);
            PrintNumbers(m);
            Console.ReadKey();
        }
        static void PrintNumbers(int[] m, bool reverse = false)
        {
            if (reverse)
            {
                for (int i = m.Length - 1; i >= 0; i--)
                {
                    Console.Write("{0} ", m[i]);
                }
            }
            else
            {
                for (int i = 0; i < m.Length; i++)
                {
                    Console.Write("{0} ", m[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
