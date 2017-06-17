using System;
using System.Linq;

namespace P06_SumReversedNumbers
{
    class P06_SumReversedNumbers
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                .Split(' ')
                .ToList();
            for (int i = 0; i < numList.Count; i++)
            {
                numList[i] = ReverseString(numList[i]);
            }

            Console.WriteLine(numList.Select(int.Parse).ToList().Sum());

        }

        static string ReverseString(string s)
        {
            var array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
