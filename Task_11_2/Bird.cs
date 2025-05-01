using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_2
{
    public class Bird: IFlyable
    {
        public int MaxAltitude { get; }
        public Bird(int maxAltitude)
        {
            MaxAltitude = maxAltitude;
        }
        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAltitude} метров");
        }
    }
}
