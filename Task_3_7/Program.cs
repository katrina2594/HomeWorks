namespace Task_3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int first = Convert.ToInt32(Console.ReadLine());
            string result = (9 < first && first < 100) ? "Да" : "Нет";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
