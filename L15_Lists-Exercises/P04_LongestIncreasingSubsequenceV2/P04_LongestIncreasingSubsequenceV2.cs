using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_LongestIncreasingSubsequenceV2
{
    class P04_LongestIncreasingSubsequenceV2
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var numListLength = numList.Count;
            var lengths = new int[numListLength]
                .Select(n => n = 1)
                .ToArray();
            var previousLongestEndIndex = lengths
                .Select(n => n = -1)
                .ToArray();
            var bestLength = 0;
            var lastIndex = -1;
            for (int anchor = 1; anchor < numListLength; anchor++)
            {
                var anchorNum = numList[anchor];
                for (int j = 0; j < anchor; j++)
                {
                    var currentNum = numList[j];
                    if (currentNum < anchorNum && lengths[j] == lengths[anchor])
                    {
                        lengths[anchor]++;
                        previousLongestEndIndex[anchor] = j;
                    }

                    if (lengths[anchor] > bestLength)
                    {
                        bestLength = lengths[anchor];
                        lastIndex = anchor;
                    }
                }
            }

            var maxSubsequenceIndex = Array.IndexOf(lengths, lengths.Max());
            var maxSubcequence = new List<int>();
            for (int i = maxSubsequenceIndex; i >= 0;)
            {
                maxSubcequence.Add(numList[i]);
                i = previousLongestEndIndex[i];
            }
            maxSubcequence.Reverse();
            Console.WriteLine(string.Join(" ", maxSubcequence));
        }
    }
}
