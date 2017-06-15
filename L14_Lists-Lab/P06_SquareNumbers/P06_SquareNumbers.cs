using System;
using System.Linq;

namespace P06_SquareNumbers
{
    class P06_SquareNumbers
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Where(n => Math.Sqrt(n) == (int)Math.Sqrt(n))
                .OrderByDescending(n => n)
                .ToList();
            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
