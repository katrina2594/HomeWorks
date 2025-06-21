using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_2
{
    public delegate void Logger(string device, string state);
    public class SmartHomeSystem
    {
        public event Logger Logger;
        bool lightStatus = false;
        int term = 0;
        bool doorStatus = false;
        public void TurnOnLight()
        {
            lightStatus = true;
            Logger?.Invoke("Освещение", "включено");
        }
        public void TurnOffLight()
        {
            lightStatus = false;
            Logger?.Invoke("Освещение", "выключено");
        }
        public void SetTemperature(int newTemp)
        {
            term = newTemp;
            Logger?.Invoke("Термостат", $"Температура изменена на {newTemp}°C");
        }
        public void LockDoor()
        {
            doorStatus = true;
            Logger?.Invoke("Дверь", "закрыта");
        }
        public void UnlockDoor()
        {
            doorStatus = false;
            Logger?.Invoke("Дверь", "открыта");
        }
    }
    
}
