using System;
using System.Collections.Generic;
using System.Linq;

namespace P08_LogsAggregator
{
    class P08_LogsAggregator
    {
        static void Main(string[] args)
        {
            
            var userIpList = new Dictionary<string, List<string>>();
            var userOverAllDuratiuon = new SortedDictionary<string, double>();
            GetUserIpData(userIpList, userOverAllDuratiuon);

            foreach (var user in userOverAllDuratiuon)
            {
                Console.WriteLine($"{user.Key}: {user.Value} [{string.Join(", ", userIpList[user.Key])}]");
            }
        }

        static void GetUserIpData(
            Dictionary<string, List<string>> userIpList,
            SortedDictionary<string, double> userOverAllDuratiuon)
        {
            var inputsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputsCount; i++)
            {
                var inputList = Console.ReadLine()
                    .Split(' ')
                    .ToList();
                var userName = inputList[1];
                var userIp = inputList[0];
                var sessionDuration = double.Parse(inputList[2]);

                if (!userIpList.ContainsKey(userName))
                {
                    userIpList[userName] = new List<string>();
                    userOverAllDuratiuon[userName] = 0;
                }

                userIpList[userName].Add(userIp);
                userIpList[userName] = userIpList[userName].Distinct().OrderBy(x => x).ToList();
                userOverAllDuratiuon[userName] += sessionDuration;
            }
        }
    }
}
