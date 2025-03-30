namespace Task_3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int first = Convert.ToInt32(Console.ReadLine());
            string result = (-10 >= first || first >= 10) ? "Да" : "Нет";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
