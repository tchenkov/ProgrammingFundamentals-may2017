using System;

namespace P08_CenterPoint
{
    class P08_CenterPoint
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            PrintClosesPointToCenterpoint(x1, y1, x2, y2);
        }

        static void PrintClosesPointToCenterpoint(double x1, double y1, double x2, double y2)
        {
            double point1Distance = x1 * x1 + y1 * y1;
            double point2Distance = x2 * x2 + y2 * y2;
            Console.WriteLine(
                point1Distance <= point2Distance ?
                $"({x1}, {y1})" :
                $"({x2}, {y2})"
                );
        }
    }
}
