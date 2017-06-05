using System;

namespace P05_CalculateTriangleArea
{
    class P05_CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double HeightA = double.Parse(Console.ReadLine());
            Console.WriteLine(GetTriangleArea(sideA, HeightA));
        }

        static double GetTriangleArea(double sideA, double heightA)
        {
            return sideA * heightA / 2;
        }
    }
}
