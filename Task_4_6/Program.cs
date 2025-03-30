using System.ComponentModel.Design;

namespace Task_4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string input = Console.ReadLine();
            int n = 0;
            bool f = true;
            if (int.TryParse(input, out n) && n > 0)
            {

                while(n>1)
                {
                    if(n%2!=0)
                    {
                        f = false;
                        break;
                    }
                    else
                    {
                        n = n / 2;
                    }
                }
                if (f)
                {
                    Console.WriteLine("Введенное число является степенью 2");
                }
                else
                {
                    Console.WriteLine("Введенное число не является степенью 2");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод");

            }
            Console.ReadKey();
        }
    }
}
