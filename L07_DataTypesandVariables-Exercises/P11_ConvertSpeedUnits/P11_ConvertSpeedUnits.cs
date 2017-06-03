using System;

namespace P11_ConvertSpeedUnits
{
    class P11_ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int totalTimeInSeconds = (hours * 60 + minutes) * 60 + seconds;

            float speedMPSec = distanceInMeters / totalTimeInSeconds;
            Console.WriteLine(speedMPSec);

            float distanceInKM = distanceInMeters / 1000;
            float totalTimeInHours = totalTimeInSeconds / 3600.0f;
            float speedKPHours = distanceInKM / totalTimeInHours;
            Console.WriteLine(speedKPHours);

            float distanceInMiles = distanceInMeters / 1609;
            float speedInMilesPerHour = distanceInMiles / totalTimeInHours;
            Console.WriteLine(speedInMilesPerHour);
        }
    }
}
