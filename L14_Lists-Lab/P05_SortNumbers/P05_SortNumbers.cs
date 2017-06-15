using System;
using System.Linq;

namespace P05_SortNumbers
{
    class P05_SortNumbers
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .OrderBy(n => n)
                .ToList();
            Console.WriteLine(string.Join(" <= ", numList));
        }
    }
}
