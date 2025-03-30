namespace Task_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int second = Convert.ToInt32(Console.ReadLine());
            if (first == second)
            {
                Console.WriteLine("Числа не должны быть равны, перезапустите программу");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Введите третье число");
                int third = Convert.ToInt32(Console.ReadLine());
                if (second == third || first == third)
                {
                    Console.WriteLine("Числа не должны быть равны, перезапустите программу");
                    Console.ReadKey();
                }
                else
                {
                    int mediana = 0;
                    if (first > second)
                    {
                        if (first > third)
                        {
                            if (second > third)
                            {
                                mediana = second;
                            }
                            else
                            {
                                mediana = third;
                            }
                        }
                        else
                        {
                            mediana = first;
                        }
                    }
                    else
                    {
                        if (second < third)
                        {
                            mediana = second;
                        }
                        else
                        {
                            if (first > third)
                            {
                                mediana = first;
                            }
                            else
                            {
                                mediana = third;
                            }
                        }
                    }
                    Console.WriteLine("Медиана {0}", mediana);
                    Console.ReadKey();
                }
            }
        }
    }
}
