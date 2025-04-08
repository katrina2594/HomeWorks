namespace Task_9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Война и мир", "Л. Толстой", 1869, 1225);
            Book book2 = new Book("Преступление и наказание", "Ф. Достоевский", 1866, 300);
            Console.WriteLine(book1.GetInfo());
            Console.WriteLine(book2.GetInfo());
            Console.ReadKey();
        }
    }
}
