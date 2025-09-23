using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_1_1
{
    class ShoppingCartServiceNew
    {
        public decimal CalculateTotalPrice(string customerType, List<decimal> itemPrices)
        {
            decimal baseTotal = 0;
            baseTotal = itemPrices.Sum();
            decimal discount = 0;
            
            if (customerType == "Regular")
            {
                discount = baseTotal * 0.05m; // 5%
            }

            decimal finalPrice = baseTotal - discount;

            Console.WriteLine($"Base: {baseTotal}, Discount: {discount}, Final: {finalPrice}");
            return finalPrice;
        }

        public decimal CalculateTotalPriceWithQuantities(string customerType, Dictionary<decimal, int> itemsWithQuantities)
        {
            List<decimal> allPrices = new List<decimal>();
            foreach (var item in itemsWithQuantities)
            {
                allPrices.Add(item.Key*item.Value);
            }

            return CalculateTotalPrice(customerType, allPrices);
        }
    }
}
