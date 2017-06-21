using System;
using System.Collections.Generic;
using System.Linq;

namespace P09_LegendaryFarming
{
    class P09_LegendaryFarming
    {
        static void Main(string[] args)
        {
            bool isLegendaryObtained = false;
            var legendaryMats = new Dictionary<string, int>
            { {"Shards", 0},{ "Fragments", 0 },{"Motes", 0 } };
            var junkMats = new SortedDictionary<string, int>();
            var legendaryName = string.Empty;

            while (!isLegendaryObtained)
            {
                var inputList = Console.ReadLine().ToLower().Split(' '). ToList();
                var matsNames = inputList.Where((v, i) => i % 2 == 1).ToList();
                var matsQuantities = inputList.Where((v, i) => i % 2 == 0).Select(int.Parse).ToList();

                foreach (var item in matsNames.Zip(matsQuantities, Tuple.Create))
                {
                    bool isMatLegendary = item.Item1 == "shards" || item.Item1 == "fragments" || item.Item1 == "motes";

                    if (isMatLegendary)
                    {
                        var key = char.ToUpper(item.Item1[0]) + item.Item1.Substring(1);
                        if (!legendaryMats.ContainsKey(key))
                        {
                            legendaryMats[key] = 0;
                        }
                        legendaryMats[key] += item.Item2;
                        //legendaryMats = legendaryMats.OrderBy(x => x.Value).ThenBy(k => k.Key).ToDictionary(k => k.Key, x => x.Value);
                        if (legendaryMats[key] >= 250)
                        {
                            isLegendaryObtained = true;
                            switch (key)
                            {
                                case "Shards":
                                    legendaryName = "Shadowmourne";
                                    break;
                                case "Fragments":
                                    legendaryName = "Valanyr";
                                    break;
                                case "Motes":
                                    legendaryName = "Dragonwrath";
                                    break;
                            }
                            legendaryMats[key] -= 250;
                            legendaryMats = legendaryMats.OrderByDescending(x => x.Value).ThenBy(k => k.Key).ToDictionary(k => k.Key, x => x.Value);
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMats.ContainsKey(item.Item1))
                        {
                            junkMats[item.Item1] = 0;
                        }
                        junkMats[item.Item1] += item.Item2;
                    }
                }
            }

            Console.WriteLine($"{legendaryName} obtained!");
            foreach (var item in legendaryMats)
            {
                Console.WriteLine($"{item.Key.ToLower()}: {item.Value}");
            }
            foreach (var item in junkMats)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
