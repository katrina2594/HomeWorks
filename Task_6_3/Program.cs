using System.Security.Cryptography;

namespace Task_6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = "Март";
            string year = "2025";
            decimal sumSale = 1234567.89M;
            int howMuch = 1234;
            decimal sumPosition = sumSale / howMuch;
            string report = String.Format("{0}\n" +
                "Отчёт о продажах за {1} {2}\n" +
                "{0}\n" +
                "Общая сумма продаж: {3:N2} р.\n" +
                "Количество проданных товаров: {4:N0} шт.\n" +
                "Средняя стоимость товара: {5:N2} р.\n" +
                "{0}", new string('-', 30), month, year,sumSale,howMuch,sumPosition);
            Console.WriteLine(report);
            Console.ReadKey();
        }
    }
}
