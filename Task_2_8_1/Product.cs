using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_8_1
{
    public enum ProductTypes
    {
        Food,
        Technique
    }
    public class Product
    {
        
        public string ProductName { get; set; }
        public int ProductCost { get; set; }
        public string ProductImage { get; set; }
        public ProductTypes ProductType { get; set; }

    }
}
