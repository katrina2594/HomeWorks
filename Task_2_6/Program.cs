namespace Task_2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину трубы в метрах");
            double lenght = Convert.ToDouble(Console.ReadLine());

            double result = Math.Round(lenght*2)/2;
            Console.WriteLine("Результат округления: {0}", result);
            Console.ReadKey();
        }
    }
}
