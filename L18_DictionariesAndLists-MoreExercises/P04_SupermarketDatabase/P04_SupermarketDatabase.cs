using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_SupermarketDatabase
{
    class P04_SupermarketDatabase
    {
        static void Main(string[] args)
        {
            var productsPrices = new Dictionary<string, double>();
            var productsQuantities = new Dictionary<string, int>();
            var command = Console.ReadLine();

            while (command != "stocked")
            {
                var commandList = command.Split(' ').ToList();
                var product = commandList[0];
                var price = double.Parse(commandList[1]);
                var quantity = int.Parse(commandList[2]);

                if (!productsQuantities.ContainsKey(product))
                {
                    productsQuantities[product] = 0;
                    productsPrices[product] = 0;
                }
                productsQuantities[product] += quantity;
                productsPrices[product] = price;

                command = Console.ReadLine();
            }
            var grandTotal = 0.0;

            foreach (var product in productsPrices.Zip(productsQuantities, Tuple.Create))
            {
                var currentProductTotalPrice = product.Item1.Value * product.Item2.Value;
                grandTotal += currentProductTotalPrice;
                Console.WriteLine(
                    $"{product.Item1.Key}: ${product.Item1.Value:f2} * {product.Item2.Value} = ${currentProductTotalPrice:f2}"
                    );
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${grandTotal:F2}");
        }
    }
}
