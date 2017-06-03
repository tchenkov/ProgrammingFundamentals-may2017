using System;

namespace P12_RectangleProperties
{
    class P12_RectangleProperties
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            double rectanglePerimeter = (sideA + sideB) * 2;
            Console.WriteLine(rectanglePerimeter);

            double rectangleArea = sideA * sideB;
            Console.WriteLine(rectangleArea);

            double rectangleDiagonal = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            Console.WriteLine(rectangleDiagonal);
        }
    }
}
