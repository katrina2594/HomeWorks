namespace Task_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[n];
            Random rnd = new Random();
            int plus = 0;
            int minus = 0;
            int zero = 0;
            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(-20, 21);
                Console.Write("{0} ", t[i]);
                if (t[i] > 0)
                {
                    plus++;
                }
                else
                {
                    if (t[i] == 0)
                        zero++;
                    else
                        minus++;
                }

            }
            Console.WriteLine();
            Console.WriteLine("Кол-во положительных чисел {0}, Кол-во отрицательных чисел {1}, Кол-во чисел равных нулю {2}", plus,minus,zero);
            Console.ReadKey();
        }
    }
}
