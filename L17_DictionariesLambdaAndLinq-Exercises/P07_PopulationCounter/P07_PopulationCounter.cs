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
            var command = Console.ReadLine();

            while (command != "report")
            {
                GetcountryCityPopulation(countryCityPopulation, command);

                command = Console.ReadLine();
            }

            PrintReport(countryCityPopulation);
        }

        static void PrintReport(
            Dictionary<string, Dictionary<string, ulong>> countryCityPopulation)
        {
            var populationInCountry = new Dictionary<string, ulong>();
            foreach (var country in countryCityPopulation)
            {
                ulong countryPopulation = GetCountryPopulation(country.Value);
                if (!populationInCountry.ContainsKey(country.Key))
                {
                    populationInCountry[country.Key] = 0;
                }
                populationInCountry[country.Key] = countryPopulation;
            }
            populationInCountry = populationInCountry.OrderByDescending(x => x.Value).ToDictionary(k => k.Key, x => x.Value);

            foreach (var country in populationInCountry)
            {
                var cityAndPopulationList = GetCityAndPopulationList(countryCityPopulation[country.Key]);
                Console.WriteLine($"{country.Key} (total population: {country.Value})");
                Console.WriteLine(string.Join("\n", cityAndPopulationList));
            }
        }

        static List<string> GetCityAndPopulationList(Dictionary<string, ulong> cityDict)
        {
            var result = new List<string>();
            foreach (var city in cityDict)
            {
                result.Add($"=>{city.Key}: {city.Value}");
            }
            return result;
        }

        static ulong GetCountryPopulation(Dictionary<string, ulong> country)
        {
            ulong population = 0;
            foreach (var city in country)
            {
                population += city.Value;
            }

            return population;
        }

        static void GetcountryCityPopulation(
            Dictionary<string, Dictionary<string, ulong>> countryCityPopulation,
            string command)
        {
            var commandLineList = command.Split('|').ToList();
            var country = commandLineList[1];
            var city = commandLineList[0];
            var currentPopulation = ulong.Parse(commandLineList[2]);

            if (!countryCityPopulation.ContainsKey(country))
            {
                countryCityPopulation[country] = new Dictionary<string, ulong>();
            }
            if (!countryCityPopulation[country].ContainsKey(city))
            {
                countryCityPopulation[country][city] = 0;
            }

            countryCityPopulation[country][city] += currentPopulation;
            countryCityPopulation[country] = countryCityPopulation[country].OrderByDescending(x => x.Value).ToDictionary(k => k.Key, x => x.Value);
        }
    }
}
