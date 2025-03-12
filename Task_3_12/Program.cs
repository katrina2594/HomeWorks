namespace Task_3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            string input = Console.ReadLine();
            int number = 0;
            if (int.TryParse(input, out number) && number >= 100 && number <= 999)
            {
                int third = number % 10;
                int second = (number / 10) % 10;
                int first = number / 100;
                string textFirst = "";
                string textSecond = "";
                string textThird = "";
                switch (first)
                {
                    case 1:
                        textFirst = "сто";
                        break;
                    case 2:
                        textFirst = "двести";
                        break;
                    case 3:
                        textFirst = "триста";
                        break;
                    case 4:
                        textFirst = "четыреста";
                        break;
                    case 5:
                        textFirst = "пятьсот";
                        break;
                    case 6:
                        textFirst = "шестьсот";
                        break;
                    case 7:
                        textFirst = "семьсот";
                        break;
                    case 8:
                        textFirst = "восемьсот";
                        break;
                    case 9:
                        textFirst = "девятьсот";
                        break;
                }
                if (second != 1)
                {
                    switch (second)
                    {
                        case 2:
                            textSecond = "двадцать";
                            break;
                        case 3:
                            textSecond = "тридцать";
                            break;
                        case 4:
                            textSecond = "сорок";
                            break;
                        case 5:
                            textSecond = "пятьдесят";
                            break;
                        case 6:
                            textSecond = "шестьдесят";
                            break;
                        case 7:
                            textSecond = "семьдесят";
                            break;
                        case 8:
                            textSecond = "восемьдесят";
                            break;
                        case 9:
                            textSecond = "девяносто";
                            break;
                    }
                    switch (third)
                    {
                        case 1:
                            textThird = "один";
                            break;
                        case 2:
                            textThird = "два";
                            break;
                        case 3:
                            textThird = "три";
                            break;
                        case 4:
                            textThird = "четыре";
                            break;
                        case 5:
                            textThird = "пять";
                            break;
                        case 6:
                            textThird = "шесть";
                            break;
                        case 7:
                            textThird = "семь";
                            break;
                        case 8:
                            textThird = "восемь";
                            break;
                        case 9:
                            textThird = "девять";
                            break;
                    }
                }
                else
                {
                    switch (third)
                    {
                        case 0:
                            textSecond = "десять";
                            break;
                        case 1:
                            textSecond = "одинадцать";
                            break;
                        case 2:
                            textSecond = "двенадцать";
                            break;
                        case 3:
                            textSecond = "тринадцать";
                            break;
                        case 4:
                            textSecond = "четырнадцать";
                            break;
                        case 5:
                            textSecond = "пятнадцать";
                            break;
                        case 6:
                            textSecond = "шестнадцать";
                            break;
                        case 7:
                            textSecond = "семнадцать";
                            break;
                        case 8:
                            textSecond = "восемьнадцать";
                            break;
                        case 9:
                            textSecond = "девятнадцать";
                            break;


                    }
                }
                Console.WriteLine("{0} {1} {2}", textFirst, textSecond, textThird);
            }
            else
            {
                Console.WriteLine("Некорректный ввод данных");
            }
            Console.ReadKey();
        }
    }
}
