using System;
using System.Numerics;

namespace P01_ConvertFromBase_10ToBase_N
{
    class P01_ConvertFromBase_10ToBase_N
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split();
            var numBase = int.Parse(inputLine[0]);
            var numberBase10 = BigInteger.Parse(inputLine[1]);
            var numString = string.Empty;

            while (numberBase10 > 0)
            {
                var remainder = numberBase10 % numBase;
                numString = remainder + numString;
                numberBase10 /= numBase;
            }

            Console.WriteLine(numString);
        }
    }
}
