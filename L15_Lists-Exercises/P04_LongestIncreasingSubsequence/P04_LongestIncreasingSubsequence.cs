using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_LongestIncreasingSubsequence
{
    class P04_LongestIncreasingSubsequence
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

            for (int i = 1; i < numListLength; i++)
            {
                var counter = 0;
                bool isCounterUsed = false;
                for (int j = 0; j < i; j++)
                {
                    if (numList[j] < numList[i])
                    {
                        var lastValidIndex = previousLongestEndIndex[i] < 0 ?
                            0 :
                            previousLongestEndIndex[i];
                        var lastValid = previousLongestEndIndex[i] < 0 ?
                            numList[j] - 1 :
                            numList[lastValidIndex];
                        var previousValid = lengths[i] > 2 && previousLongestEndIndex[lastValidIndex] >= 0 ?
                            numList[previousLongestEndIndex[lastValidIndex]] :
                            numList[j] - 1;
                        if (j - 1 < 0)
                        {
                            lengths[i]++;
                            counter++;
                            isCounterUsed = true;
                            previousLongestEndIndex[i] = j;
                            lastValid = numList[j];
                        }
                        else if (lastValid >= numList[j] && numList[j] > previousValid)
                        {
                            previousLongestEndIndex[i] = j;
                        }
                        else if (numList[j] > previousValid)
                        {
                            lengths[i]++;
                            counter++;
                            isCounterUsed = true;
                            previousLongestEndIndex[i] = j;
                        }
                        else if (counter == 0 && isCounterUsed)
                        {
                            lengths[i]++;
                            previousLongestEndIndex[i] = j;
                            isCounterUsed = false;
                        }
                        if (counter > 0 && previousValid > numList[j] && isCounterUsed)
                        {
                            counter--;
                        }
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
