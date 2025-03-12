namespace Task_3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int first = Convert.ToInt32(Console.ReadLine());
            string result = (first % 2 == 0) ? "Да" : "Нет";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
