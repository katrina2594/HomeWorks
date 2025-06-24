using System.Collections.Generic;

namespace Task_15_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> emails = new HashSet<string>();
            emails.Add("alice@example.com");
            emails.Add("bob@example.com");
            emails.Add("charlie@example.com");

            Console.WriteLine($"Дубликат alice@example.com добавлен? {emails.Add("alice@example.com")}");
            Console.WriteLine($"Есть ли bob@example.com в подписчиках? {emails.Contains("bob@example.com")}");
            Console.WriteLine($"Есть ли dave@example.com в подписчиках? {emails.Contains("dave@example.com")}");

            HashSet<string> emails2 = new HashSet<string>();
            emails2.Add("bob@example.com");
            emails2.Add("dave@example.com");
            emails2.Add("eve@example.com");

            HashSet<string> union = new HashSet<string>(emails);
            union.UnionWith(emails2);
            Console.WriteLine("Подписчики после объединения:");
            EmailsPrint(union);
            emails.IntersectWith(emails2);
            Console.WriteLine("Общие подписчики:");
            EmailsPrint(emails);

            Console.WriteLine($"Удалили charlie@example.com? {union.Remove("charlie@example.com")}");
            Console.WriteLine($"Всего подписчиков: {union.Count}");

            Console.WriteLine($"testGroup является подмножеством? {emails2.IsSubsetOf(union)}");
            union.Clear();
            Console.WriteLine($"Подписчиков после очистки: {union.Count}");

            Console.ReadKey();


        }
        public static void EmailsPrint(HashSet<string> emails)
        {
            foreach (string adress in emails)
            {
                Console.WriteLine($"- {adress}");
            }
        }
    }
}
