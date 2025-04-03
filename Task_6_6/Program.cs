using System.Text.RegularExpressions;

namespace Task_6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?=.*[0-9])(?=.*[A-Z])(?=.*[a-z])(?=.*[!#%?*])[0-9A-Za-z!#%?*]{14,}$";
            Regex regex = new Regex(pattern);
            string test = "";
            do
            {
                Console.WriteLine("Введите пароль:");
                test = Console.ReadLine();
            }
            while (!regex.IsMatch(test));
            Console.WriteLine("Пароль корректный");
            Console.ReadKey();
        }

    }
}
