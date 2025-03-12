using System.Diagnostics.Metrics;

namespace Task_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину трубы в метрах");
            double lenght = Convert.ToDouble(Console.ReadLine());
            double result = Math.Ceiling(lenght);
            Console.WriteLine("Результат округления: {0}", result);
            Console.ReadKey();
        }
    }
}
