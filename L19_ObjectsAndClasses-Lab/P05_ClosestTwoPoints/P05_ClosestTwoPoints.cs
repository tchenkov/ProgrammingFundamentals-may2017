using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_ClosestTwoPoints
{
    class P05_ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            List<Point> points = GetPoints();
                        
            PrintClosestTwoPointsData(points);
        }

        private static void PrintClosestTwoPointsData(List<Point> points)
        {
            var minDistancePints = new List<Point>(2);
            var minDistance = GetMinDisnatce(points, ref minDistancePints);

            Console.WriteLine($"{minDistance:f3}");
            foreach (var point in minDistancePints)
            {
                Console.WriteLine($"({point.X}, {point.Y})");
            }
        }

        static double GetMinDisnatce(List<Point> allPoints, ref List<Point> closestTwoPoints)
        {
            var minDistance = double.MaxValue;
            var pointsCount = allPoints.Count;
            for (int p1 = 0; p1 < pointsCount -1; p1++)
            {
                for (int p2 = p1 + 1; p2 < pointsCount; p2++)
                {
                    var currentDistance = GetDistance(allPoints[p1], allPoints[p2]);
                    if (minDistance > currentDistance)
                    {
                        closestTwoPoints.Clear();
                        minDistance = currentDistance;
                        closestTwoPoints.Add(allPoints[p1]);
                        closestTwoPoints.Add(allPoints[p2]);
                    }
                }
            }

            return minDistance;
        }

        static List<Point> GetPoints()
        {
            var pointsCount = int.Parse(Console.ReadLine());
            var points = new List<Point>(pointsCount);
            for (int i = 0; i < pointsCount; i++)
            {
                var pointList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                points.Add(
                    new Point
                    {
                        X = pointList[0],
                        Y = pointList[1]
                    }
                );
            }

            return points;
        }

        static double GetDistance(Point point1, Point point2)
            => point1.DistanceTo(point2);
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
