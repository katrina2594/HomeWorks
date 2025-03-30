namespace Task_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину отрезка в дюймах");
            double inch = Convert.ToDouble(Console.ReadLine());
            double convetionToCentimeters = inch * 2.54;
            int meters = (int) convetionToCentimeters / 100;
            convetionToCentimeters -=  meters * 100;
            int centemeters = (int)convetionToCentimeters;
            double millimeters = (convetionToCentimeters - centemeters)*10;
            millimeters = Math.Round(millimeters,2);

            Console.WriteLine("{0} дюйм = {1} м {2} см {3} мм", inch, meters, centemeters, millimeters);
            Console.ReadKey();



        }
    }
}
