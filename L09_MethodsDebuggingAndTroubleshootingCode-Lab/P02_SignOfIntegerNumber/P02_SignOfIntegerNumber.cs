using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SignOfIntegerNumber
{
    class P02_SignOfIntegerNumber
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            PrintMessageSignOfNumber(number);
        }

        private static void PrintMessageSignOfNumber(long number)
        {
            Console.WriteLine(
                number > 0 ? $"The number {number} is positive." :
                number < 0 ? $"The number {number} is negative." :
                $"The number {number} is zero.");
        }
    }
}
