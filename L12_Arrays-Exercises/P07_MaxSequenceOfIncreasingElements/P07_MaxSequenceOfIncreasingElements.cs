using System;
using System.Linq;

namespace P07_MaxSequenceOfIncreasingElements
{
    class P07_MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            int[] arrayInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int startIndex = 0;
            int lenght = 1;
            int maxStartindex = 0;
            int maxLenth = 1;
            for (int i = 1; i < arrayInput.Length; i++)
            {
                if (arrayInput[i] > arrayInput[i - 1])
                {
                    lenght++;
                    if (lenght > maxLenth)
                    {
                        maxLenth = lenght;
                        maxStartindex = startIndex;
                    }
                }
                else
                {
                    startIndex = i;
                    lenght = 1;
                }
            }

            for (int i = maxStartindex; i < maxStartindex + maxLenth; i++)
            {
                Console.Write(arrayInput[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
