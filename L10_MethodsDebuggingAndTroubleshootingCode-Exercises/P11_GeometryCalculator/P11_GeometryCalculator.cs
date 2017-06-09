using System;

namespace P11_GeometryCalculator
{
    class P11_GeometryCalculator
    {
        static void Main(string[] args)
        {
            var geometryFigure = Console.ReadLine();
            double result = 0;
            switch (geometryFigure)
            {
                case "triangle":
                    var sideA = double.Parse(Console.ReadLine());
                    var heightA = double.Parse(Console.ReadLine());
                    result = GetTriangleArea(sideA, heightA);
                    break;
                case "square":
                    var squareSide = double.Parse(Console.ReadLine());
                    result = GetRectangleArea(squareSide);
                    break;
                case "rectangle":
                    var rectangleSideA = double.Parse(Console.ReadLine());
                    var rectangleSideB = double.Parse(Console.ReadLine());
                    result = GetRectangleArea(rectangleSideA, rectangleSideB);
                    break;
                case "circle":
                    var radius = double.Parse(Console.ReadLine());
                    result = GetCyrcleArea(radius);
                    break;
            }
            Console.WriteLine($"{result:f2}");
        }


        static double GetCyrcleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        static double GetRectangleArea(double squareSide)
        {
            return squareSide * squareSide;
        }

        static double GetRectangleArea(double sideA, double sideB)
        {
            return sideA * sideB;
        }

        static double GetTriangleArea(double sideA, double heightA)
        {
            return sideA * heightA / 2;
        }
    }
}
