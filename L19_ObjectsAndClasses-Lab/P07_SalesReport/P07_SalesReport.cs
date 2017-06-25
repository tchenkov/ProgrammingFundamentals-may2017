using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_SalesReport
{
    class P07_SalesReport
    {
        static void Main(string[] args)
        {
            Sale[] sales = GetSales();

            SortedDictionary<string, decimal> salresByCity = GetSalesByCity(sales);

            PrintSales(salresByCity);
        }

        static void PrintSales(SortedDictionary<string, decimal> salresByCity)
        {
            foreach (var profit in salresByCity)
            {
                Console.WriteLine($"{profit.Key} -> {profit.Value:f2}");
            }
        }

        static SortedDictionary<string, decimal> GetSalesByCity(Sale[] sales)
        {
            var salesByCity = new SortedDictionary<string, decimal>();

            foreach (var sale in sales)
            {
                if (!salesByCity.ContainsKey(sale.City))
                {
                    salesByCity[sale.City] = 0;
                }
                salesByCity[sale.City] += sale.Profit;
            }

            return salesByCity;
        }

        static Sale[] GetSales()
        {
            var salesCount = int.Parse(Console.ReadLine());
            var sales = new Sale[salesCount];

            for (int i = 0; i < salesCount; i++)
            {
                var saleData = Console.ReadLine().Split(' ').ToArray();
                sales[i] = new Sale
                {
                    City = saleData[0],
                    Product = saleData[1],
                    Price = decimal.Parse(saleData[2]),
                    Quantity = decimal.Parse(saleData[3])
                };
            }

            return sales;
        }
    }

    class Sale
    {
        public string City { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public decimal Profit
        {
            get
            {
                return Price * Quantity;
            }
        }
    }
}
