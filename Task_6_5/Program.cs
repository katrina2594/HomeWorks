using System.Text.RegularExpressions;

namespace Task_6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] test = {
            "+7(123)456-78-90",
            "+7(987)654-32-10",
            "+7(123)456-78-9",
            "7(123)456-78-90",
            "+7 123 456 78 90",
            "+7(123)456-7890",
            "+7(123)456-78-9a",
            "+7(123)45f-78-90",
            "+7(1ы3)456-78-90",
            "+8(123)456-78-90",
        };
            string pattern = @"^\+7\([0-9]{3}\)[0-9]{3}-[0-9]{2}-[0-9]{2}$";
            Regex regex = new Regex(pattern);
            foreach (string s in test)
            {
                if (regex.IsMatch(s))
                {
                    Console.WriteLine("{0} Номер корректный", s);
                }
                else
                {
                    Console.WriteLine("{0} Номер некорректный", s);
                }
            }
            Console.ReadKey();

        }
    }
}
