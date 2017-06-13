using System;
using System.Linq;

namespace P06_MaxSequenceOfEqualElementsV2
{
    class P06_MaxSequenceOfEqualElementsV2
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
                if (arrayInput[i] == arrayInput[i -1])
                {
                    lenght++;
                }
                else
                {
                    startIndex = i;
                    lenght = 1;
                }
                if (lenght > maxLenth)
                {
                    maxLenth = lenght;
                    maxStartindex = i - lenght + 1;
                }                
            }

            int[] arrayOutput = arrayInput
                .Skip(maxStartindex)
                .Take(maxLenth)
                .ToArray();
            Console.WriteLine(string.Join(" ", arrayOutput));
        }
    }
}
