using System;
using System.Linq;

namespace P01_SortTimes
{
    class P01_SortTimes
    {
        static void Main(string[] args)
        {
            var timeList = Console.ReadLine()
                .Split(' ')
                .OrderBy(t => t)
                .ToList();
            Console.WriteLine(string.Join(", ", timeList));
        }
    }
}
