using System.Collections.Generic;

namespace Task_8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите возраст:");
            int age = Convert.ToInt32(Console.ReadLine());
            try
            {
                ValidateAge(age);
                Console.WriteLine("Возраст корректный");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Введены некорректные параметры: {ex.Message}");
            }
            Console.ReadKey();
        }
        static void ValidateAge(int a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Возраст не может быть отрицательным");
            }
            if (a > 150)
            {
                throw new ArgumentOutOfRangeException("Слишком большой возраст");
            }
        }
    }
}

