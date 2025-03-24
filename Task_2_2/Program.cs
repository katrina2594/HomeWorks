namespace Task_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите градусы");
            int degrees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минуты");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите секунды");
            int seconds = Convert.ToInt32(Console.ReadLine());
            double secondsToDegrees = seconds / 3600;
            double minutesToDegrees = minutes / 60;
            double cornerInDegrees = degrees + secondsToDegrees + minutesToDegrees;
            double radians = cornerInDegrees * (Math.PI / 180);
            Console.WriteLine("Значение в радианах {0}", radians);
            Console.ReadKey();



        }
    }
}
