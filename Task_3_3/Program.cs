using System.Security.Claims;

namespace Task_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите четвертое число");
            int forth = Convert.ToInt32(Console.ReadLine());
         
            int max1 = Math.Max(first, second);
            int max2 = Math.Max(third, forth);
            int max = Math.Max(max1, max2);
            Console.WriteLine("Максимальное число {0}",max);
            Console.ReadKey();
        }
    }
}
