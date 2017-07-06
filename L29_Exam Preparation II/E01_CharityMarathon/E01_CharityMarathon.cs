using System;

namespace E01_CharityMarathon
{
    class E01_CharityMarathon
    {
        static void Main(string[] args)
        {
            var durationDays = int.Parse(Console.ReadLine());
            var runnersCount = int.Parse(Console.ReadLine());
            var avLabsPerRunner = int.Parse(Console.ReadLine());
            var trackLength = double.Parse(Console.ReadLine()); // meters
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyPerKm = double.Parse(Console.ReadLine()); // money per kilometer

            var totalRunners = durationDays * trackCapacity < runnersCount ?
                durationDays * trackCapacity :
                runnersCount;

            var totalMeters = totalRunners * avLabsPerRunner * trackLength;
            var totalKilometers = totalMeters / 1000;
            var moneyRaised = totalKilometers * moneyPerKm;

            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
