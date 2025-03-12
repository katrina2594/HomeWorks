namespace Task_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int third = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            if (first < second)
            {
                max = second;
            }
            else
            {
                max = first;
            }
            if (max < third)
            {
                max = third;
            }
            Console.WriteLine("Максимальное число {0}", max);
            Console.ReadKey();
        }
    }
}
