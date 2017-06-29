using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_VehicleCatalogue
{
    class P02_VehicleCatalogue
    {
        static void Main(string[] args)
        {
            List<Vehilce> catalog = new List<Vehilce>();
            GetVehicles(catalog);
            PrintVehiclesByRequest(catalog);
            PrintAverageHp(catalog, true);
            PrintAverageHp(catalog, false);
        }

        static void PrintAverageHp(List<Vehilce> catalog, bool isCar)
        {
            var hpList = catalog
                .Where(type => type.IsCar == isCar)
                .ToList();                
            var averageHp = hpList.Count == 0 ?
                0.0 :
                hpList.Select(v => (double)v.Horsepower)
                .Average();
            var vehicleType = isCar ? "Car" : "Truck";
            Console.WriteLine($"{vehicleType}s have average horsepower of: {averageHp:f2}.");
        }

        static void PrintVehiclesByRequest(List<Vehilce> catalog)
        {
            var brand = Console.ReadLine();

            while (brand != "Close the Catalogue")
            {
                Console.WriteLine(catalog.First(v => v.Brand == brand));

                brand = Console.ReadLine();
            }
        }

        static void GetVehicles(List<Vehilce> catalog)
        {
            var command = Console.ReadLine();

            while (command != "End")
            {
                var vehicleInfo = command.Split(' ');
                var newVehicle = new Vehilce
                {
                    IsCar = vehicleInfo[0].ToLower() == "car",
                    Brand = vehicleInfo[1],
                    Color = vehicleInfo[2],
                    Horsepower = short.Parse(vehicleInfo[3])
                };

                catalog.Add(newVehicle);

                command = Console.ReadLine();
            }
        }
    }

    class Vehilce
    {
        public bool IsCar { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public short Horsepower { get; set; }

        public override string ToString()
        {
            var vehicleType = IsCar ? "Car" : "Truck";
            var output = $"Type: {vehicleType}\r\n";
            output += $"Model: {Brand}\r\n";
            output += $"Color: {Color}\r\n";
            output += $"Horsepower: {Horsepower}";
            return output;
        }
    }
}
