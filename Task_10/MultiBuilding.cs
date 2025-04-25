using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    sealed class MultiBuilding : Building
    {
        protected int _floors;
        protected bool _hasElevator;
        public double AreaPerFloor
        {
            get
            {
                return _area / _floors;
            }
        }
        public MultiBuilding(string address, double area, int yearBuilt, int floors, bool hasElevator)
            : base(address, area, yearBuilt)
        {
            _floors = floors;
            _hasElevator = hasElevator;
        }
        public override double CalculateTax()
        {
            double taxWithoutEl = (_area * 1000) * (1 + (_floors - 1) * 0.05);
            if (_hasElevator)
            {
                return taxWithoutEl + 5000;
            }
            else
            {
                return taxWithoutEl;
            }
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Кол-во этажей: {_floors},\nНаличие лифта: {_hasElevator}");
        }





    }
}


