using System.Collections.Generic;

namespace Task_3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ширину участка");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину участка");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину 1го дома");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину 1го дома");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину 2го дома");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину 2го дома");
            int r = Convert.ToInt32(Console.ReadLine());

            if ((p + r <= a && Math.Max(q, s) <= b) ||
                (q + s <= b && Math.Max(p, r) <= a) ||
                (p + s <= a && Math.Max(q, r) <= b) ||
                (p + s <= b && Math.Max(q, r) <= a))
            {
                Console.WriteLine("Можно разместить дома с указанными габаритами на этом участке");
            }
            else
            {
                Console.WriteLine("Не удалось разместить дома с указанными габаритами на этом участке");
            }
            Console.ReadKey();
        }
    }
}
