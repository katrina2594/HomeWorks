using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16_1
{
    class Computer
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string ProcessorType { get; set; }
        public int Frequency { get; set; }
        public int RAMsize { get; set; }
        public int HardDriveSize { get; set; }
        public int VideocardSize { get; set; }
        public decimal Cost { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return $"Код: {Code} Модель: {Name} Процессор: {ProcessorType} Частота процессора: {Frequency} Объем RAM: {RAMsize} Объем диска: {HardDriveSize} Видеокарта: {VideocardSize} Цена: {Cost} В наличии: {Count}шт.";
        }

    }
}
