using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_1
{
    public abstract class Animal
    {
        public abstract string Name { get; }
        public abstract string Say();
        public string ShowInfo()
        {
            return Name +" "+ Say();
        }
    }
}
