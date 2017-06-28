using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_AndreyAndBilliard
{
    class P07_AndreyAndBilliard
    {
        static void Main(string[] args)
        {
            var barPrices = GetPrices();
            var customers = GetCustomersOrders(barPrices);
            PrintBillsAndTotalProfit(customers);
        }

        static void PrintBillsAndTotalProfit(List<Customer> customers)
        {
            decimal TotalBill = 0;
            foreach (var customer in customers)
            {
                TotalBill += customer.Bill;
                Console.WriteLine(customer.Name);
                Console.WriteLine(string.Join("\r\n", customer.Order.Select(p => $"-- {p.Key} - {p.Value}")));
                //foreach (var order in customer.Order)
                //{
                //    Console.WriteLine($"-- {order.Key} - {order.Value}");
                //}
                Console.WriteLine($"Bill: {customer.Bill:f2}");
            }
            Console.WriteLine($"Total bill: {TotalBill:f2}");
        }

        static List<Customer> GetCustomersOrders(Dictionary<string, decimal> barPrices)
        {
            var customers = new SortedDictionary<string, Customer>();
            var command = Console.ReadLine();

            while (command != "end of clients")
            {
                var commandList = command.Split(new char[] { '-', ',' }).ToList();
                var customerName = commandList[0];
                var product = commandList[1];
                var quantity = int.Parse(commandList[2]);

                if (!barPrices.ContainsKey(product))
                {
                    command = Console.ReadLine();
                    continue;
                }
                if (!customers.ContainsKey(customerName))
                {
                    customers[customerName] = new Customer()
                    {
                        Name = customerName,
                        Order = new Dictionary<string, int>(),
                        Bill = 0M
                    };
                }
                if (!customers[customerName].Order.ContainsKey(product))
                {
                    customers[customerName].Order.Add(product, 0);
                }
                customers[customerName].Order[product] += quantity;
                customers[customerName].Bill += quantity * barPrices[product];
                
                command = Console.ReadLine();
            }

            return customers.Select(v => v.Value).ToList();
        }

        static Dictionary<string, decimal> GetPrices()
        {
            var barPrices = new Dictionary<string, decimal>();
            var itemsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < itemsCount; i++)
            {
                var itemAndPrice = Console.ReadLine().Split('-').ToArray();
                var item = itemAndPrice[0];
                var price = decimal.Parse(itemAndPrice[1]);
                if (!barPrices.ContainsKey(item))
                {
                    barPrices[item] = 0;
                }
                barPrices[item] = price;
            }
            return barPrices;
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> Order = new Dictionary<string, int>();
        public decimal Bill { get; set; }
    }
}
