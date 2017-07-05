using System;
using System.Collections.Generic;
using System.Linq;

namespace E02_SoftUniKaraoke
{
    class E02_SoftUniKaraoke
    {
        static void Main(string[] args)
        {
            var awards = new Dictionary<string, List<string>>();
            GetAwards(awards);
            PrintAwards(awards);
        }

        static void PrintAwards(Dictionary<string, List<string>> awards)
        {
            if (awards.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            awards = awards
                .OrderByDescending(ac => ac.Value.Count)
                .ThenBy(n => n.Key)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var person in awards)
            {
                Console.WriteLine($"{person.Key}: {person.Value.Count} awards");
                foreach (var award in person.Value)
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }

        static void GetAwards(Dictionary<string, List<string>> awards)
        {
            List<string> namesList = GetList();
            var songsList = GetList();
            var command = Console.ReadLine();

            while (!command.Equals("dawn", StringComparison.InvariantCultureIgnoreCase))
            {
                var separator = new string[] { ", " };
                var commandList = command
                    .Split(separator, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (commandList.Count < 3)
                {
                    command = Console.ReadLine();
                    continue;
                }

                var currentName = commandList[0];
                var currentSong = commandList[1];
                var award = commandList[2];
                if (!namesList.Contains(currentName) ||
                    !songsList.Contains(currentSong))
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (!awards.ContainsKey(currentName))
                {
                    awards[currentName] = new List<string>();
                }
                if (!awards[currentName].Contains(award))
                {
                    awards[currentName].Add(award);
                    awards[currentName] = awards[currentName]
                        .OrderBy(a => a)
                        .ToList();
                }

                command = Console.ReadLine();
            }
        }

        static List<string> GetList()
        {
            var separator = new string[] { ", " };
            return Console.ReadLine()
                .Split(separator, StringSplitOptions.None)
                .ToList();
        }
    }
}
