namespace Task_2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1е число:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2е число:");
            int second = Convert.ToInt32(Console.ReadLine());
            first +=second;
            second = first - second;
            first -= second;
            Console.WriteLine("Результат: 1е число {0}, 2е число {1}", first, second);
            Console.ReadKey();

        }
    }
}
