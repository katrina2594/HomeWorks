using System.Threading.Channels;

namespace Task_16_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>
            {
                new Computer() { Code = "PC01", Name = "Dell Inspiron", ProcessorType = "Intel Core i5", Frequency = 3200, RAMsize = 8, HardDriveSize = 512, VideocardSize = 2, Cost = 55000, Count = 4 },
                new Computer() { Code = "PC02", Name = "HP Pavilion", ProcessorType = "Intel Core i5", Frequency = 3600, RAMsize = 16, HardDriveSize = 1000, VideocardSize = 6, Cost = 78000, Count = 7 },
                new Computer() { Code = "PC03", Name = "Lenovo ThinkCentre", ProcessorType = "AMD Ryzen 5", Frequency = 3400, RAMsize = 8, HardDriveSize = 256, VideocardSize = 4, Cost = 60000, Count = 2 },
                new Computer() { Code = "PC04", Name = "Acer Aspire", ProcessorType = "Intel Core i3", Frequency = 2900, RAMsize = 4, HardDriveSize = 500, VideocardSize = 2, Cost = 35000, Count = 5 },
                new Computer() { Code = "PC05", Name = "Apple iMac", ProcessorType = "Apple M1", Frequency = 3200, RAMsize = 16, HardDriveSize = 512, VideocardSize = 8, Cost = 115000, Count = 1 },
                new Computer() { Code = "PC06", Name = "Asus ROG", ProcessorType = "Intel Core i9", Frequency = 4200, RAMsize = 32, HardDriveSize = 2000, VideocardSize = 12, Cost = 180000, Count = 3 },
                new Computer() { Code = "PC07", Name = "MSI Trident", ProcessorType = "AMD Ryzen 7", Frequency = 3800, RAMsize = 16, HardDriveSize = 1000, VideocardSize = 8, Cost = 95000, Count = 2 },
                new Computer() { Code = "PC08", Name = "HP EliteDesk", ProcessorType = "Intel Core i5", Frequency = 3100, RAMsize = 8, HardDriveSize = 512, VideocardSize = 2, Cost = 52000, Count = 6 },
                new Computer() { Code = "PC09", Name = "Dell XPS", ProcessorType = "Intel Core i7", Frequency = 4000, RAMsize = 16, HardDriveSize = 1000, VideocardSize = 6, Cost = 105000, Count = 2 },
                new Computer() { Code = "PC10", Name = "Lenovo Legion", ProcessorType = "AMD Ryzen 9", Frequency = 4500, RAMsize = 32, HardDriveSize = 2000, VideocardSize = 16, Cost = 195000, Count = 31 }
            };

            Console.WriteLine("Введите название процессора:");
            string pName = Console.ReadLine();

            var result = computers
                .Where(c => c.ProcessorType == pName)
                .ToList();
            PrintList(result);
            Console.WriteLine();
            Console.WriteLine("Введите объем ОЗУ:");
            string pRAM = Console.ReadLine();

            result = computers
               .Where(c => c.ProcessorType == pRAM)
               .ToList();
            PrintList(result);
            Console.WriteLine();
            Console.WriteLine("Список по увеличению стоимости:");
            result = computers
               .OrderBy(c => c.Cost)
               .ToList();
            PrintList(result);
            Console.WriteLine();
            Console.WriteLine("Список сгруппированный по типу процессора:");
            var result2 = computers
               .GroupBy(c => c.ProcessorType)
                .Select(g => new
                {
                    ProcessorType = g.Key,
                    Computers = g.Select(c => c)
                });
            foreach (var l in result2)
            {
                Console.WriteLine($"Тип процессора: {l.ProcessorType}");
                PrintList(l.Computers.ToList());
            }
            Console.WriteLine();
            Console.WriteLine("Самый бюджетный компьютер:");
            var chCost = result
                .First();
            Console.WriteLine(chCost.ToString());
            Console.WriteLine();
            Console.WriteLine("Самый дорогой компьютер:");
            var exCost = result
                .Last();
            Console.WriteLine(exCost.ToString());
            Console.WriteLine();
            Console.WriteLine("Есть ли компьютеры в кол-ве не менее 30шт:");
            var result3 = computers
                .Where(c => c.Count >= 30)
                .ToList();
            if(result3.Count>0)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
                Console.ReadKey();
        }
        public static void PrintList(List<Computer> list)
        {
            foreach (Computer p in list)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }

}
