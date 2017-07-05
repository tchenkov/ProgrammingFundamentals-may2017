using System;
using System.Globalization;

namespace E01_SinoTheWalker_v2
{
    class E01_SinoTheWalker_v2
    {
        static void Main(string[] args)
        {   // the good and still working verion
            var timeFormat = "HH:mm:ss";
            var timeString = Console.ReadLine();
            var startTime = DateTime.ParseExact(
                timeString, timeFormat, CultureInfo.InvariantCulture);
            var stepsCount = long.Parse(Console.ReadLine());
            var secondsPerStep = int.Parse(Console.ReadLine());
            var travelTime = (stepsCount * secondsPerStep) % (3600 * 24);
            var arriveTime = startTime.AddSeconds(travelTime);
            Console.WriteLine($"Time Arrival: {arriveTime:HH:mm:ss}");
        }
    }
}
