namespace Task_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число из 4х цифр");
            int number = Convert.ToInt32 (Console.ReadLine());
            int first = number / 1000;
            int second = (number / 100) % 10;
            int third = (number / 10) % 10;
            int last = number % 10;
            int result = first * 1000 + last * 100 + third * 10 + second;
            Console.WriteLine("Преобразованное число:{0}",result);
            Console.ReadKey();
            

        }
    }
}
