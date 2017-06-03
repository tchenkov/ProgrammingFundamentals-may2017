using System;

namespace P04_TouristInformation
{
    class P04_TouristInformation
    {
        static void Main(string[] args)
        {
            string imperialUnits = Console.ReadLine();
            decimal impUnitsValue = decimal.Parse(Console.ReadLine());
            decimal metricValue = 0;
            string metricUnits = "";

            switch (imperialUnits)
            {
                case "miles":
                    metricUnits = "kilometers";
                    metricValue = impUnitsValue * 1.6m;
                    break;
                case "inches":
                    metricUnits = "centimeters";
                    metricValue = impUnitsValue * 2.54m;
                    break;
                case "feet":
                    metricUnits = "centimeters";
                    metricValue = impUnitsValue * 30m;
                    break;
                case "yards":
                    metricUnits = "meters";
                    metricValue = impUnitsValue * 0.91m;
                    break;
                case "gallons":
                    metricUnits = "liters";
                    metricValue = impUnitsValue * 3.8m;
                    break;
            }

            Console.WriteLine($"{impUnitsValue} {imperialUnits} = {metricValue:F2} {metricUnits}");
        }
    }
}
