using System.ComponentModel.Design;
using System.Security.Claims;

namespace Task_3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int first = Convert.ToInt32(Console.ReadLine());
            if (first % 10 == 0)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
            Console.ReadKey();                                               
                           
        }
    }
}
