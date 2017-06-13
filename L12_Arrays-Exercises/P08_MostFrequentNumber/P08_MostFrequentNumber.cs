using System;
using System.Collections.Generic;
using System.Linq;

namespace P08_MostFrequentNumber
{
    class P08_MostFrequentNumber
    {
        static void Main(string[] args)
        {
            var arrayInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var countPerNum = new Dictionary<int, int>();
            for (int i = 0; i < arrayInput.Length; i++)
            {
                if (!countPerNum.ContainsKey(arrayInput[i]))
                {
                    countPerNum.Add(arrayInput[i], 0);
                }
                countPerNum[arrayInput[i]]++;
            }

            int maxValue = countPerNum.Values.Max();
            var leftmostNJumber = countPerNum
                .Where(n => n.Value == maxValue)
                .Select(n => n.Key)
                .Take(1)
                .ToArray()
                .Sum();
            Console.WriteLine(leftmostNJumber);
        }
    }
}
