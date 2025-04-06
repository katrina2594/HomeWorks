using System.Collections.Generic;

namespace Task_8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое целое число");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе целое число");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции где: 1 - сложение, 2 - вычитание, 3 - умножение, 4 - деление");
                int code = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                string operationName = "";
                switch (code)
                {
                    case 1:
                        result = a + b;
                        operationName = "+";
                        break;
                    case 2:
                        result = a - b;
                        operationName = "-";
                        break;
                    case 3:
                        result = a * b;
                        operationName = "*";
                        break;
                    case 4:
                        result = a / b;
                        operationName = "/";
                        break;
                    default:
                        throw new FormatException("Ошибка: введен некорректный код операции, правило: от 1 до 4");
                }
                Console.WriteLine($"Результат операции {a} {operationName} {b} = {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Введены некорректные параметры: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
