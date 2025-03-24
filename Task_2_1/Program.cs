using System.Security.Claims;

namespace Task_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = a;
            a = c;
            c = b;
            b = d;
            Console.WriteLine("Ответ a= {0}, b={1},c={2}", a,b,c  );
            Console.ReadKey();
        }
    }
}
