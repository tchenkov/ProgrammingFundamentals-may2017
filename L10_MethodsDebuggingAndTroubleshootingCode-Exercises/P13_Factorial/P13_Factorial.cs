using System;
using System.Numerics;

namespace P13_Factorial
{
    class P13_Factorial
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            PrintFactorialOF(number);
        }

        static void PrintFactorialOF(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}
