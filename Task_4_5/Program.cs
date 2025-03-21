namespace Task_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string input = "";
            do
            {
                Console.WriteLine("Введите число в диапазоне [20;60]");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out number) || number < 20 || number > 60);
            Console.ReadKey();
        }
    }
}
