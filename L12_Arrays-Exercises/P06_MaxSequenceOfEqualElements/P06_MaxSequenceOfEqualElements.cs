using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_MaxSequenceOfEqualElements
{
    class P06_MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] arrayInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var stringList = new List<string> { arrayInput[0].ToString() };
            int j = 0;
            for (int i = 1; i < arrayInput.Length; i++)
            {
                if (arrayInput[i] == arrayInput[i - 1])
                {
                    stringList[j] += $" {arrayInput[i]}";
                    continue;
                }
                stringList.Add(arrayInput[i].ToString());
                j++;
            }
            int maxSequenceIndex = 0;
            int maxSequenceLenght = 0;
            for (int i = 0; i < stringList.Count; i++)
            {
                if (maxSequenceLenght < stringList[i].Length)
                {
                    maxSequenceLenght = stringList[i].Length;
                    maxSequenceIndex = i;
                }
            }
            Console.WriteLine(stringList[maxSequenceIndex]);
        }
    }
}
