using System;
using System.Linq;

namespace P06_Heists
{
    class P06_Heists
    {
        static void Main(string[] args)
        {
            var lootPricese = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var jewelsPrice = lootPricese[0];
            var goldPrice = lootPricese[1];
            double totalMoney = 0;
            var commandString = Console.ReadLine();
            while (commandString != "Jail Time")
            {
                var heistElements = 
                    commandString
                    .Split(' ')
                    .ToArray();
                int jewelsQuantity = heistElements[0].Where(ch => ch == '%').Count();
                int goldQuantity = heistElements[0].Where(ch => ch == '$').Count();
                var currentHeistCost = double.Parse(heistElements[1]);
                totalMoney += 
                    (jewelsQuantity * jewelsPrice) +
                    (goldQuantity * goldPrice) -
                    currentHeistCost;
                commandString = Console.ReadLine();
            }

            Console.WriteLine(
                totalMoney < 0 ?
                $"Have to find another job. Lost: {Math.Abs(totalMoney)}." :
                $"Heists will continue. Total earnings: {totalMoney}."
                );            
        }
    }
}
