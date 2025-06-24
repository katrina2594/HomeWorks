namespace Task_15_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> catalogue = new Dictionary<string, int>();
            catalogue.Add("A001", 10);
            catalogue.Add("B205", 25);
            catalogue.Add("C307", 15);


            Console.WriteLine($"Есть ли товар с артикулом B205? {catalogue.ContainsKey("B205")}");

            catalogue["A001"] = 8;

            if (catalogue.TryGetValue("C307", out int value))
            { 
                Console.WriteLine($"Количество наушников: {value}"); 
            }

            catalogue["B205"] += 5;

            catalogue.Remove("C307");

            Console.WriteLine($"Текущие товары:");
            foreach (KeyValuePair<string, int> position in catalogue)
            {
                Console.WriteLine($"Артикул: {position.Key}, Количество: {position.Value}");
            }
            bool empty = catalogue.Count == 0;
            Console.WriteLine($"Список пуст? {empty}");

            catalogue.Clear();
            Console.WriteLine($"Количество товаров после очистки: {catalogue.Count}");

            Console.ReadKey();


        }
    }
}
