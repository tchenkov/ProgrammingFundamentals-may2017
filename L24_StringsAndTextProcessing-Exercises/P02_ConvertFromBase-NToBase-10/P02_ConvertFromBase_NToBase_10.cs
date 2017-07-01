using System;
using System.Linq;
using System.Numerics;

namespace P02_ConvertFromBase_NToBase_10
{
    class P02_ConvertFromBase_NToBase_10
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split();
            var numBase = inputLine[0];
            var numberString = inputLine[1].Reverse().ToArray();
            BigInteger sum = 0;

            for (int i = 0; i < numberString.Length; i++)
            {
                sum += int.Parse(numberString[i].ToString()) * NotMathPow(numBase, i);
            }

            Console.WriteLine(sum);
        }

        static BigInteger NotMathPow(string num, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            var bigIntNum = BigInteger.Parse(num);
            BigInteger result = bigIntNum;
            for (int i = 1; i < power; i++)
            {
                result *= bigIntNum;
            }
            return result;
        }
    }
}
