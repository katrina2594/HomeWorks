using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_1
{
    public class Dog : Animal
    {
        public override string Name
        {
            get
            {
                return "Собака";
            }
        }
        public override string Say()
        {
            return "Гав!";
        }
    }
}
