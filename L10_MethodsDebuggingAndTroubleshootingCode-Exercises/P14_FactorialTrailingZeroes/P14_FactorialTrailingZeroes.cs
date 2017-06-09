using System;
using System.Numerics;

namespace P14_FactorialTrailingZeroes
{
    class P14_FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            PrintFactorialTraillingZeroesCount(number);
        }

        static void PrintFactorialTraillingZeroesCount(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            
            int traillingZeroesCount = 0;
            while (factorial % 10 == 0)
            {
                traillingZeroesCount++;
                factorial /= 10;
            }
            Console.WriteLine(traillingZeroesCount);
        }
    }
}
