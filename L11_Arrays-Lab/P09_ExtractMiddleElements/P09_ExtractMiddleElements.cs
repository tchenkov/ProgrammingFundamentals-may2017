using System;
using System.Linq;

namespace P09_ExtractMiddleElements
{
    class P09_ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int middleIndex = arrayOfInts.Length / 2;
            Console.WriteLine(
                arrayOfInts.Length == 1 ?
                $"{arrayOfInts[0]}" :
                arrayOfInts.Length % 2 == 1 ?
                $"{arrayOfInts[middleIndex - 1]}\n{arrayOfInts[middleIndex]}\n{arrayOfInts[middleIndex + 1]}" :
                $"{arrayOfInts[middleIndex - 1]}\n{arrayOfInts[middleIndex]}"
            );
        }
    }
}
