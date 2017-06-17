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

            for (int i = 0; i < numListLength; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    if (j < i)
                    {

                    }
                }
            }
        }
    }
}
