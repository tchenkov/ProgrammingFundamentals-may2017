using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_SrybskoUnleashed
{
    class P10_SrybskoUnleashed
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var venueSingerProfit = new Dictionary<string, Dictionary<string, long>>();
            var venueTotalProfit = new Dictionary<string, long>();

            while (command != "End")
            {
                var singer = command.Split('@').First().ToString().Trim();
                var concertInfo = command.Split('@').Last().ToString();
                var concertInfoList = concertInfo.Split(' ').ToList();
                if (concertInfoList.Count < 3)
                {
                    command = Console.ReadLine();   
                    continue;
                }
                var ticketPrice = int.Parse(concertInfoList[concertInfoList.Count - 2]);
                var ticketsCount = long.Parse(concertInfoList[concertInfoList.Count - 1]);
                concertInfoList.RemoveRange(concertInfoList.Count - 2, 2);
                var venue = string.Join(" ", concertInfoList);
                if (!venueTotalProfit.ContainsKey(venue))
                {
                    venueTotalProfit[venue] = 0;
                    venueSingerProfit[venue] = new Dictionary<string, long>();
                }
                if (!venueSingerProfit[venue].ContainsKey(singer))
                {
                    venueSingerProfit[venue][singer] = 0;
                }
                var currentProfit = ticketPrice * ticketsCount;
                venueTotalProfit[venue] += currentProfit;
                venueSingerProfit[venue][singer] += currentProfit;
                venueSingerProfit[venue] = venueSingerProfit[venue]
                    .OrderByDescending(p => p.Value)
                    .ThenBy(k => k.Key)
                    .ToDictionary(k => k.Key, p => p.Value);


                command = Console.ReadLine();
            }

            foreach (var venue in venueTotalProfit)
            {
                Console.WriteLine(venue.Key);

                foreach (var singer in venueSingerProfit[venue.Key])
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
