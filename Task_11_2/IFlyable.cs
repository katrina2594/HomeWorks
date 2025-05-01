using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_2
{
    interface IFlyable
    {
        public int MaxAltitude { get; }
        public void Fly();
    }
}
