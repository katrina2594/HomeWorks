namespace Task_7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double edgeLength = 5;
            Console.WriteLine($"Длина ребра куба: {edgeLength}");
            CalcCube(edgeLength, out double volume, out double surfaceArea);
            Console.WriteLine($"Объем куба: {volume}");
            Console.WriteLine($"Площадь поверхности куба: {surfaceArea}");
            Console.ReadKey();

        }
        static void CalcCube(double edgeLength, out double volume, out double surfaceArea)
        {
            volume = Math.Pow(edgeLength, 3);
            surfaceArea = 6 * Math.Pow(edgeLength, 2);
        }
    }
}
