using System;
using System.Linq;

namespace P03_SumAdjacentEqualNumbers
{
    class P03_SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();
            int i = 0;
            while (i < numList.Count - 1)
            {
                if (numList[i] == numList[i + 1])
                {
                    double num = numList[i] + numList[i + 1];
                    numList.Insert(i, num);
                    numList.RemoveAt(i + 1);
                    numList.RemoveAt(i + 1);
                    i = 0;
                    continue;
                }
                i++;
            }
            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
