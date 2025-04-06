namespace Task_7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = FindMax(15, 25, 5, 30, 15,35,2,45,8);
            Console.WriteLine($"Max number: {maxNumber}");
            Console.ReadKey();
        }
        static int FindMax(params int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            return max;
        }
    }
}
