using System;

namespace P03_MilesToKilometers
{
    public class P03_MilesToKilometers
    {
        public static void Main(string[] args)
        {
            var distanceInMiles = double.Parse(Console.ReadLine());
            const double kilometersPerMile = 1.60934;
            var distanceInKilometers = distanceInMiles * kilometersPerMile;

            Console.WriteLine("{0:F2}", distanceInKilometers);
        }
    }
}
