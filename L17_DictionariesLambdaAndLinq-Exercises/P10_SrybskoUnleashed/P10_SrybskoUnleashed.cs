using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_SrybskoUnleashed
{
    class P10_SrybskoUnleashed
    {
        static void Main(string[] args)
        {
            var venueSingerProfit = new Dictionary<string, Dictionary<string, long>>();

            GetVenueSingerProfit(venueSingerProfit);

            PrintVenueSingerProfit(venueSingerProfit);
        }
        
        static void GetVenueSingerProfit(Dictionary<string, Dictionary<string, long>> venueSingerProfit)
        {
            var command = Console.ReadLine();
            while (command != "End")
            {
                var singer = command.Split('@').First();
                var concertData = command.Substring(command.IndexOf('@') + 1);
                if (!singer.EndsWith(" ") || singer.Length < 2)
                {
                    command = Console.ReadLine();
                    continue;
                }
                singer = singer.Trim();

                var concertDataList = concertData.Split(' ').ToList();

                if (!int.TryParse(concertDataList[concertDataList.Count - 1], out int ticketCount) ||
                    !int.TryParse(concertDataList[concertDataList.Count - 2], out int ticketPrice) ||
                    concertDataList.Count < 3)
                {
                    command = Console.ReadLine();
                    continue;
                }

                var venue = string.Join(" ",
                    concertDataList.Take(concertDataList.Count - 2));

                if (!venueSingerProfit.ContainsKey(venue))
                {
                    venueSingerProfit[venue] = new Dictionary<string, long>();
                }
                if (!venueSingerProfit[venue].ContainsKey(singer))
                {
                    venueSingerProfit[venue][singer] = 0;
                }
                venueSingerProfit[venue][singer] += ticketPrice * ticketCount;
                venueSingerProfit[venue] = venueSingerProfit[venue]
                    .OrderByDescending(p => p.Value)
                    .ToDictionary(k => k.Key, p => p.Value);

                command = Console.ReadLine();
            }
        }

        static void PrintVenueSingerProfit(Dictionary<string, Dictionary<string, long>> venueSingerProfit)
        {
            foreach (var venue in venueSingerProfit)
            {
                Console.WriteLine(venue.Key);
                Console.WriteLine(string.Join("\n",
                    venue.Value
                    .Select(s => $"#  {s.Key} -> {s.Value}")
                    ));
            }
        }
    }
}
