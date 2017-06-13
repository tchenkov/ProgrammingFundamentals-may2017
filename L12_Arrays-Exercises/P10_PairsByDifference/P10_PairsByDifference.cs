using System;
using System.Linq;

namespace P10_PairsByDifference
{
    class P10_PairsByDifference
    {
        static void Main(string[] args)
        {
            var arrayOfInts = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            double difference = double.Parse(Console.ReadLine());
            var counter = 0;
            for (int i = 0; i < arrayOfInts.Length -1; i++)
            {
                for (int j = i + 1; j < arrayOfInts.Length; j++)
                {
                    if (Math.Abs(arrayOfInts[i] - arrayOfInts[j]) == difference)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
