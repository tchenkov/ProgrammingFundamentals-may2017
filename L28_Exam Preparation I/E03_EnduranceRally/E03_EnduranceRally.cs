using System;
using System.Collections.Generic;
using System.Linq;

namespace E03_EnduranceRally
{
    class E03_EnduranceRally
    {
        static void Main(string[] args)
        {
            var driversNames = Console.ReadLine()
                .Split();
            var trackLayout = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            var checkpoints = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var drivers = GetDriversStats(driversNames);
            foreach (var currentDriver in drivers)
            {
                for (int i = 0; i < trackLayout.Length; i++)
                {
                    currentDriver.Fuel = checkpoints.Contains(i) ?
                        currentDriver.Fuel + trackLayout[i] :
                        currentDriver.Fuel - trackLayout[i];
                    if (currentDriver.Fuel <= 0)
                    {
                        Console.WriteLine($"{currentDriver.Name} - reached {i}");
                        break;
                    }
                }
                if (currentDriver.Fuel > 0)
                {
                    Console.WriteLine($"{currentDriver.Name} - fuel left {currentDriver.Fuel:f2}");
                }
            }
        }

        private static List<Driver> GetDriversStats(string[] driversNames)
        {
            var drivers = new List<Driver>();
            foreach (var driver in driversNames)
            {
                drivers.Add(
                    new Driver
                    {
                        Name = driver,
                        Fuel = driver[0]
                    }
                );
            }

            return drivers;
        }
    }

    class Driver
    {
        public string Name { get; set; }
        public double Fuel { get; set; }
    }
}
