namespace Task_14_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -2, -1, 0, 1, 2, 3 };
            int[] m1 = Transform(numbers, value => value * 2);
            int[] m2 = Transform(numbers, value => value * value);
            int[] m3 = Transform(numbers, value => Math.Abs(value));

            Console.WriteLine($"Удвоенный массив: {string.Join(",", m1)}");
            Console.WriteLine($"Массив в квадрате: {string.Join(",", m2)}");
            Console.WriteLine($"Модули чисел исходного массива: {string.Join(",", m3)}");
            Console.ReadKey();

        }
        public delegate int Transformer(int value);
        public static int[] Transform(int[] numbers, Transformer transformer)
        {
            int[] newNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                newNumbers[i] = transformer(numbers[i]);
            }
            return newNumbers;
        }
    }
}

