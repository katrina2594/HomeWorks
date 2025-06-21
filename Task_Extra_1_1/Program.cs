namespace Task_Extra_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int value = rnd.Next(1, 101);
            int n = 0;
            bool rightNumber = false;
            int a = 0;
            while (rightNumber == false)
            {
                a++;
                Console.WriteLine("Введите число от 1 до 100");
                string input = Console.ReadLine();

                if (int.TryParse(input, out n) && n > 0 && n < 101)
                {

                    if (n > value)
                    {
                        Console.WriteLine("Вы ввели большее число");
                    }
                    else
                    {
                        if (n < value)
                        {
                            Console.WriteLine("Вы ввели меньшее число");
                        }
                        else
                        {
                            rightNumber = true;
                        }
                    }


                }
                else
                {
                    Console.WriteLine("Введено некорректное значение. Введите число от 1 до 100");
                }
            }
            Console.WriteLine($"Вы угадали число. Кол-во попыток:{a}");
            Console.ReadKey();

        }
    }
}
