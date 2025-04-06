namespace Task_7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = 3;
            int b1 = 4;
            int c1 = 5;
            int a2 = 6;
            int b2 = 7;
            int c2 = 8;
            double sq1 = Square(a1, b1, c1);
            Console.WriteLine($"Площадь 1-го треугольника: {sq1}");
            double sq2 = Square(a2, b2, c2);
            Console.WriteLine($"Площадь 2-го треугольника: {sq2}");
            if (sq1 > sq2)
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else
            {
                if (sq1 < sq2)
                {
                    Console.WriteLine("Площадь второго треугольника больше");
                }
                else
                {
                    Console.WriteLine("Площадь треугольников равны");
                }
            }

            Console.ReadKey();

        }
        static double Square(int n1, int n2, int n3)
        {
            double pp = (n1 + n2 + n3) / 2.0;
            return Math.Pow(pp * (pp - n1) * (pp - n2) * (pp - n3), 0.5);
        }
    }
}
