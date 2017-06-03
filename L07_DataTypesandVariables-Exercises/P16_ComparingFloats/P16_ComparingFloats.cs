using System;

namespace P16_ComparingFloats
{
    class P16_ComparingFloats
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double difference = Math.Abs(num1 - num2);
            const double eps = 0.000001;
            bool areNumsRelativelyEqual = difference < eps;
            Console.WriteLine(areNumsRelativelyEqual);
        }
    }
}
