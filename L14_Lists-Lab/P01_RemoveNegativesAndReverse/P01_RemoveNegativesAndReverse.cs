using System;
using System.Linq;

namespace P01_RemoveNegativesAndReverse
{
    class P01_RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Where(n => n >= 0)
                .Reverse()
                .ToList();
            Console.WriteLine(
                numList.Count == 0 ?
                "empty" :
                string.Join(" ", numList)
                );
        }
    }
}
