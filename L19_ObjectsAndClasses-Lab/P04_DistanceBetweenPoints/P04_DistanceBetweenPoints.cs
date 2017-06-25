using System;
using System.Linq;

namespace P04_DistanceBetweenPoints
{
    class P04_DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            Point[] points = GetPoints();

            var distance = GetDistance(points[0], points[1]);

            Console.WriteLine($"{distance:f3}");
        }

        static double GetDistance(Point point1, Point point2)
            => point1.DistanceTo(point2);

        static Point[] GetPoints()
        {
            var pointsCount = 2;
            var points = new Point[pointsCount];
            for (int i = 0; i < pointsCount; i++)
            {
                var pointList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                points[i] = new Point
                {
                    X = pointList[0],
                    Y = pointList[1]
                };
            }

            return points;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public double DistanceTo(Point point)
        {
            var sideA = Math.Abs(X - point.X);
            var sideB = Math.Abs(Y - point.Y);
            var distance = Math.Sqrt(sideA * sideA + sideB * sideB);
            return distance;
        }
    }
}
