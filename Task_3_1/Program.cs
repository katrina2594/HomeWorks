namespace Task_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int second = Convert.ToInt32(Console.ReadLine());
            string result = "";
            if (first < second)
            {
                result = "<";
            }
            else
            {
                if (first > second)
                {
                    result = ">";
                }
                else
                {
                    result = "=";
                }
            }
            Console.WriteLine("{0}{1}{2}", first, result, second);
            Console.ReadKey();
        }
    }
}
