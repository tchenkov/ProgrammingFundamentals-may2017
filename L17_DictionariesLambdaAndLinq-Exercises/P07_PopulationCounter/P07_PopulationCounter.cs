using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_PopulationCounter
{
    class P07_PopulationCounter
    {
        static void Main(string[] args)
        {
            var countryCityPopulation =
                new Dictionary<string, Dictionary<string, ulong>>();
            var countryPopulation = new Dictionary<string, ulong>();
            GetPopulation(countryCityPopulation, countryPopulation);

            PrintReport(countryCityPopulation, countryPopulation);
        }

        static void GetPopulation(
            Dictionary<string, Dictionary<string, ulong>> countryCityPopulation,
            Dictionary<string, ulong> countryPopulation)
        {
            var command = Console.ReadLine();

            while (command != "report")
            {
                var commandLineList = command.Split('|').ToList();
                var country = commandLineList[1];
                var city = commandLineList[0];
                var currentPopulation = ulong.Parse(commandLineList[2]);

                if (!countryCityPopulation.ContainsKey(country))
                {
                    countryCityPopulation[country] = new Dictionary<string, ulong>();
                    countryPopulation[country] = 0;

                }
                if (!countryCityPopulation[country].ContainsKey(city))
                {
                    countryCityPopulation[country][city] = 0;
                }

                countryPopulation[country] += currentPopulation;
                countryCityPopulation[country][city] += currentPopulation;
                countryCityPopulation[country] = 
                    countryCityPopulation[country]
                    .OrderByDescending(x => x.Value)
                    .ToDictionary(k => k.Key, x => x.Value);

                command = Console.ReadLine();
            }
        }
        
        static void PrintReport(
            Dictionary<string, Dictionary<string, ulong>> countryCityPopulation,
            Dictionary<string, ulong> countryPopulation)
        {
           countryPopulation = countryPopulation.OrderByDescending(x => x.Value).ToDictionary(k => k.Key, x => x.Value);

            foreach (var country in countryPopulation)
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");
                Console.WriteLine(string.Join("\n", 
                    countryCityPopulation[country.Key]
                    .Select(cityPopulation => $"=>{cityPopulation.Key}: {cityPopulation.Value}")));
            }
        }
    }
}
