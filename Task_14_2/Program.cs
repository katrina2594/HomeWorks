namespace Task_14_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartHomeSystem smart = new SmartHomeSystem();
            smart.Logger += (string device, string state) =>
            {
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {device}: {state}");
            };
            smart.TurnOnLight();
            smart.TurnOffLight();
            smart.LockDoor();
            smart.UnlockDoor();
            smart.SetTemperature(25);
            Console.ReadKey();
        }
    }
}
