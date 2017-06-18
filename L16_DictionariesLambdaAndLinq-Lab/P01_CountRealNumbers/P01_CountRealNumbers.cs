using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_CountRealNumbers
{
    class P01_CountRealNumbers
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse);
            var numDict = new SortedDictionary<double, int>();
            foreach (var num in numList)
            {
                if (!numDict.ContainsKey(num))
                {
                    numDict[num] = 0;
                }
                numDict[num]++;
            }

            foreach (var item in numDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
