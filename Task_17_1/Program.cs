using System.Drawing;

namespace Task_17_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Метод Main запущен");
            Task<int[]> task1 = Task.Run(() => GenerateArray(10));
            Task<double> task2 = task1.ContinueWith(t =>
            {
                int[] a = t.Result;
                return AverageNumber(a);
            });
            Console.WriteLine($"Среднее арифметическое = {task2.Result}");
            Console.WriteLine();

            MethodAsync().Wait();

            Console.WriteLine("Метод Main завершен");
            Console.ReadKey();
        }
        public static int[] GenerateArray(int size)
        {
            Console.WriteLine("Метод GenerateArray запущен");
            var random = new Random();
            int[] array = new int[size];
            for(int i=0;i<size;i++)
            {
                array[i] = random.Next(0,10);
                Console.Write($"{array[i]} ");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\nМетод GenerateArray завершен");
            return array;
        }
        public static double AverageNumber(int[] array)
        {
            Console.WriteLine("Метод AverageNumber запущен");
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum+=array[i];
                Thread.Sleep(1000);
            }
            Console.WriteLine("Метод AverageNumber завершен");
            return (double)sum / (double)array.Length;
        }
        public static async Task MethodAsync()
        {
            Console.WriteLine("MethodAsync запущен");
            int[] arr = await Task.Run(()=>GenerateArray(10));
            double num = await Task.Run(() => AverageNumber(arr));
            Console.WriteLine($"Среднее арифметическое = {num}");
            Console.WriteLine("MethodAsync завершен");

        }
    }
}
