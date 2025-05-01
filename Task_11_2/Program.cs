namespace Task_11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] flyables = new IFlyable[]
            {
                new Bird(5000),
                new Airplane(10000,500),
            };
            foreach (IFlyable flyable in flyables)
            {
                flyable.Fly();
            }
            Console.ReadKey();
        }
    }
}
