using System;
using System.Linq;

namespace P03_FoldAndSumV2
{
    class P03_FoldAndSumV2
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] foldedArray = new int[array.Length / 2];

            int arrayIndex = (foldedArray.Length / 2) - 1;
            for (int i = 0; i < foldedArray.Length / 2; i++, arrayIndex--)
            {
                foldedArray[i] = array[arrayIndex];
            }

            arrayIndex = array.Length - (array.Length/4);
            for (int i = foldedArray.Length - 1; i >= foldedArray.Length / 2; i--, arrayIndex++)
            {
                foldedArray[i] = array[arrayIndex];
            }

            for (int i = 0; i < foldedArray.Length; i++)
            {
                foldedArray[i] += array[i + (array.Length/ 4)];
            }

            Console.WriteLine(string.Join(" ", foldedArray));
        }
    }
}
