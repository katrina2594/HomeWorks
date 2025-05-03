using static System.Reflection.Metadata.BlobBuilder;

namespace Task_12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book<string, int>[] books1 = new Book<string, int>[]
            {
             new Book<string, int>("Книга 1","Иванов А.", 1984, "F-1234"),
             new Book<string, int>("Книга 2","Иванов А.", 1985, "42456"),
             new Book<string, int>("Книга 3","Иванов А.", 1986, "ghbvth"),
             new Book<string, int>("Книга 4","Иванов А.", 1987, "144"),
            };
            Book<int, string>[] books2 = new Book<int, string>[]
            {
             new Book<int, string>("Книга 1","Иванов А.", "Исторический период1", 156),
             new Book<int, string>("Книга 2","Иванов А.", "Исторический период2", 84),
             new Book<int, string>("Книга 3","Иванов А.", "Исторический период3", 42),
             new Book<int, string>("Книга 4","Иванов А.", "Исторический период4", 188),
            };

            Book<string, int> b1 = FindBook<string, int>(books1, "F-1234");
            if (b1 != null)
            {
                Console.WriteLine($"Найдена книга: {b1}");
            }
            else
            {
                Console.WriteLine($"Книга с таким кодом не найдена");
            }
            Book<int, string> b2 = FindBook<int, string>(books2, 42);
            if (b2 != null)
            {
                Console.WriteLine($"Найдена книга: {b2}");
            }
            else
            {
                Console.WriteLine($"Книга с таким кодом не найдена");
            }
            Console.ReadKey();


        }
        public static Book<T, U> FindBook<T, U>(Book<T, U>[] books, T code)
        {
            foreach (Book<T, U> book in books)
            {
                if (book.Code.Equals(code))
                {
                    return book;
                }

            }
            return null;
        }
    }
}
