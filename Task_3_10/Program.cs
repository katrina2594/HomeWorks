namespace Task_3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество домов");
            int houses = Convert.ToInt32(Console.ReadLine());
            int housesLast = houses % 10;
            string textLast = "";
            if (1 < housesLast && housesLast < 5 && (houses < 10 || houses > 20))
            {
                textLast = "а";
            }
            if (housesLast == 0 || 5 <= housesLast && 9 >= housesLast || 10 <= houses && 14 >= houses)
            {
                textLast = "ов";
            }
            Console.WriteLine("Мы построили {0} дом{1}", houses, textLast);
            Console.ReadKey();
        }
    }
}
