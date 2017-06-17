using System;
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
            var numListLenth = numList.Count;
            var currentIndex = 0;
            var currentCount = 1;
            var maxIndex = 0;
            var maxCount = 1;
            for (int i = 1; i < numListLenth; i++)
            {
                if (numList[i] == numList[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                    currentIndex = i;
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    maxIndex = i - maxCount + 1;
                }
            }
            numList = numList
                .Skip(maxIndex)
                .Take(maxCount)
                .ToList();
            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
