using System;
using System.Globalization;
// 18:56
namespace E01_SoftuniCoffeeOrders
{
    class E01_SoftuniCoffeeOrders
    {
        static void Main(string[] args)
        {
            var ordersCount = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int i = 0; i < ordersCount; i++)
            {
                var capsulePrice = decimal.Parse(Console.ReadLine());
                var date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsuleCount = int.Parse(Console.ReadLine());

                var daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

                var currentPrice = capsulePrice * capsuleCount * daysInMonth;

                Console.WriteLine($"The price for the coffee is: ${currentPrice:f2}");
                totalPrice += currentPrice;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
