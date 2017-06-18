using System;
using System.Linq;

namespace P04_Largest3Numbers
{
    class P04_Largest3Numbers
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .Take(3)
                .ToList();
            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
