namespace Task_15_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> teamNames = new List<string>();
            teamNames.Add("Иванов");
            teamNames.Add("Петров");
            teamNames.Add("Сидоров");

            teamNames.Insert(1, "Козлов");

            bool petrov=teamNames.Contains("Петров");
            Console.WriteLine($"Есть ли игрок 'Петров' в команде ? {petrov}");

            teamNames.Remove("Сидоров");

            int indexKozlov = teamNames.IndexOf("Козлов");
            Console.WriteLine($"Индекс игрока 'Козлов': {indexKozlov}");

            teamNames.Sort();

            for(int i=0; i<teamNames.Count;i++)
            {
                Console.WriteLine($"{i+1}. {teamNames[i]}");
            }

            bool teamEmpty = teamNames.Count == 0;
            Console.WriteLine($"Команда пуста?  {teamEmpty}");
            teamNames.Clear();
            Console.WriteLine($"Количество игроков после очистки: {teamNames.Count}");

            Console.ReadKey();
        }
    }
}
