using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_CountNumbers
{
    class P07_CountNumbers
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var numDictionary = new Dictionary<int, int>();
            foreach (var num in numList)
            {
                if (!numDictionary.ContainsKey(num))
                {
                    numDictionary.Add(num, 0);
                }
                numDictionary[num]++;
            }
            foreach (var num in numDictionary.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
