using System.Text;

namespace Task_6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            string age = Console.ReadLine();
            Console.WriteLine("Введите город");
            string city = Console.ReadLine();
            StringBuilder st = new StringBuilder();
            st.AppendFormat("Имя: {0}, Возраст: {1}, Город: {2}", name, age, city);
            Console.WriteLine(st);
            Console.ReadKey();
        }
    }
}
