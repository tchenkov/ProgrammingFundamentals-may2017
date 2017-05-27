using System;

namespace P10_TriangleOfNumbers
{
    class P10_TriangleOfNumbers
    {
        static void Main(string[] args)
        {
            var triangleSize = int.Parse(Console.ReadLine());
            for (int i = 1; i <= triangleSize; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
