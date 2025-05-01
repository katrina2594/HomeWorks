namespace Task_11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
                new Dog(),
                new Cat(),
            };
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ShowInfo());
            }
            Console.ReadKey();
        }
    }
}
