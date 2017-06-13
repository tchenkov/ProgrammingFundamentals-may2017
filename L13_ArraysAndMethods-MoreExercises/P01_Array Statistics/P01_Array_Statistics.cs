using System;
using System.Linq;

namespace P01_Array_Statistics
{
    class P01_Array_Statistics
    {
        static void Main(string[] args)
        {
            var numArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int min = numArray.Min();
            int max = numArray.Max();
            int sum = numArray.Sum();
            double average = numArray.Average();

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
