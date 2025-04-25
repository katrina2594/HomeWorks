namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building("г. Екатеринбург, ул. Ленина, д.1",105,2015);
            MultiBuilding building2 = new MultiBuilding("г. Екатеринбург, ул. Малышева, д.10", 110, 2018,10,true);

            Building upBuilding = building2;
            MultiBuilding downBuilding1 = (MultiBuilding)upBuilding;
            if (building1 is MultiBuilding)
            {
                MultiBuilding downBuilding2 = building1 as MultiBuilding;
            }

            building1.DisplayInfo();
            Console.WriteLine("Возраст здания в годах: {0}",building1.BuildingAge);
            Console.WriteLine("Рассчитанный налог для здания 1: {0} руб.", building1.CalculateTax());
            building2.DisplayInfo();
            Console.WriteLine("Возраст здания в годах: {0}", building2.BuildingAge);
            Console.WriteLine("Средняя площадь здания на этаж: {0} м2", building2.AreaPerFloor);
            Console.WriteLine("Рассчитанный налог для здания 2: {0} руб.", building2.CalculateTax());
            Console.ReadKey();
        }
    }
}
