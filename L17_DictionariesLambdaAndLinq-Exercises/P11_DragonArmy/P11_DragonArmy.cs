using System;
using System.Collections.Generic;
using System.Linq;

namespace P11_DragonArmy
{
    class P11_DragonArmy
    {
        static void Main(string[] args)
        {
            var dragonsTypeNameStats = new Dictionary<string, SortedDictionary<string, List<int>>>();

            GetDragonsInfo(dragonsTypeNameStats);

            PrintDragonInfo(dragonsTypeNameStats);
        }

        static void GetDragonsInfo(Dictionary<string, SortedDictionary<string, List<int>>> dragonsTypeNameStats)
        {
            var dragonsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < dragonsCount; i++)
            {
                var dataList = Console.ReadLine().Split(' ').ToList();
                var dragonType = dataList[0];
                var name = dataList[1];
                int damage = int.TryParse(dataList[2], out damage) ? damage : 45;
                int health = int.TryParse(dataList[3], out health) ? health : 250;
                int armor = int.TryParse(dataList[4], out armor) ? armor : 10;

                if (!dragonsTypeNameStats.ContainsKey(dragonType))
                {
                    dragonsTypeNameStats[dragonType] = new SortedDictionary<string, List<int>>();
                }
                if (!dragonsTypeNameStats[dragonType].ContainsKey(name))
                {
                    dragonsTypeNameStats[dragonType][name] = new List<int>();
                }
                else
                {
                    dragonsTypeNameStats[dragonType][name].Clear();
                }
                dragonsTypeNameStats[dragonType][name].Add(damage);
                dragonsTypeNameStats[dragonType][name].Add(health);
                dragonsTypeNameStats[dragonType][name].Add(armor);
            }
        }

        static string GetDragonTypeAverageStats(SortedDictionary<string, List<int>> dragonNames)
        {
            var damageList = new List<int>();
            var healthList = new List<int>();
            var armorList = new List<int>();
            foreach (var name in dragonNames)
            {
                damageList.Add(name.Value[0]);
                healthList.Add(name.Value[1]);
                armorList.Add(name.Value[2]);
            }

            return $"{damageList.Average():f2}/{healthList.Average():f2}/{armorList.Average():f2}";
        }

        static void PrintDragonInfo(Dictionary<string, SortedDictionary<string, List<int>>> dragonsTypeNameStats)
        {
            foreach (var dragonType in dragonsTypeNameStats)
            {
                Console.WriteLine($"{dragonType.Key}::({GetDragonTypeAverageStats(dragonType.Value)})");
                Console.WriteLine(string.Join("\n",
                    dragonType.Value
                    .Select(s => $"-{s.Key} -> damage: {s.Value[0]}, health: {s.Value[1]}, armor: {s.Value[2]}")
                    ));
            }
        }
    }
}
