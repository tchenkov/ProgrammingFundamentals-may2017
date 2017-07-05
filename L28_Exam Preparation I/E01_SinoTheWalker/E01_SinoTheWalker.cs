using System;
using System.Linq;

namespace E01_SinoTheWalker
{
    class E01_SinoTheWalker
    {
        static void Main(string[] args)
        {   // the very bad but working version
            var startTime = Console.ReadLine()
                .Split(':')
                .Select(int.Parse)
                .ToArray();
            var stepsCount = long.Parse(Console.ReadLine());
            var secondsPerStep = int.Parse(Console.ReadLine());
            var travelTime = stepsCount * secondsPerStep;
            travelTime = travelTime % (3600 * 24);
            var travelSeconds = travelTime % 60;
            travelTime = (travelTime - travelSeconds) / 60;
            var travelMinutes = travelTime % 60;
            travelTime = (travelTime - travelMinutes) / 60;
            var travelHours = travelTime;
            var arriveSeconds = (travelSeconds + startTime[2]) % 60;
            var add = (travelSeconds + startTime[2]) / 60;
            var arriveMinutes = (add + travelMinutes + startTime[1]) % 60;
            add = (add + travelMinutes + startTime[1]) / 60;
            var arriveHour = (add + travelHours + startTime[0]) % 24;

            Console.WriteLine($"Time Arrival: {arriveHour:d2}:{arriveMinutes:d2}:{arriveSeconds:d2}");
        }
    }
}
