using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_1_1
{
    public class ShoppingCartService
    {
        public decimal CalculateTotalPrice(string customerType, List<decimal> itemPrices)
        {
            decimal baseTotal = 0;
            // В строках 15 по 18 нарушается принцип KISS, можно обойтись без цикла
            for (int i = 0; i < itemPrices.Count; i++)
            {
                baseTotal += itemPrices[i];
            }

            decimal discount = 0;
            // В строках с 26 по 37 нарушение принципа YAGNI так как поддерживаем только Regular на данном этапе

            if (customerType == "Regular")
            {
                discount = baseTotal * 0.05m; // 5%
            }
            else if (customerType == "Premium")
            {
                discount = baseTotal * 0.15m; // 15%
                if (discount > 1000)
                {
                    discount = 1000 + (discount - 1000) * 0.1m;
                }
            }
            else if (customerType == "VIP")
            {
                discount = baseTotal * 0.20m; // 20%
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
                // В строках 51 по 54 нарушается принцип KISS, можно обойтись без цикла
                for (int i = 0; i < item.Value; i++)
                {
                    allPrices.Add(item.Key);
                }
            }

            return CalculateTotalPrice(customerType, allPrices);
        }
    }
}
