using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_MaxSequenceOfEqualElements
{
    class P01_MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var numListLength = numList.Count;
            var tempList = new List<int> { numList[0] };
            var maxList = new List<int> { numList[0] };
            
            for (int i = 1; i < numListLength; i++)
            {
                if (numList[i] == numList[i - 1])
                {
                    tempList.Add(numList[i]);
                    maxList = tempList.Count > maxList.Count ?
                        new List<int>(tempList) :
                        maxList;
                }
                else
                {
                    tempList.Clear();
                    tempList.Add(numList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", maxList));
        }
    }
}
