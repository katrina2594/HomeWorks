using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Building
    {
        protected string _address;
        protected double _area;
        protected int _yearBuilt;

        public int BuildingAge
        {
            get
            {
                return DateTime.Now.Year - _yearBuilt;
            }
        }

        public Building(string address, double area, int yearBuilt)
        {
            _address = address;
            _area = area;
            _yearBuilt = yearBuilt;
        }
        public virtual double CalculateTax()
        {
            return _area * 1000;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"\nАдрес здания: {_address},\nПлощадь: {_area}\nГод постройки: {_yearBuilt}");
        }
    }

}
