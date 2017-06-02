using System;

namespace P03_ExactSumOfRealNumbers
{
    class P03_ExactSumOfRealNumbers
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());
            decimal sum = 0m;
            for (int i = 0; i < numCount; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
