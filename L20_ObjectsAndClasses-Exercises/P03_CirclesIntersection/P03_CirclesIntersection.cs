using System;
using System.Linq;

namespace P03_CirclesIntersection
{
    class P03_CirclesIntersection
    {
        static void Main(string[] args)
        {
            Circle c1 = GetCircle();
            Circle c2 = GetCircle();

            bool areCirclesIntersecting = Intersect(c1, c2);

            Console.WriteLine(
                areCirclesIntersecting ?
                "Yes" :
                "No"
            );
        }

        static bool Intersect(Circle c1, Circle c2)
        {
            var distance = c1.Center.DistanceTo(c2.Center);
            return distance < c1.Radius + c2.Radius ?
                true :
                false;
        }

        static Circle GetCircle()
        {
            var circleData = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var circle = new Circle
            {
                Center = GetPoint(circleData[0], circleData[1]),
                Radius = circleData[2]
            };
            
            return circle;
        }

        static Point GetPoint(double v1, double v2)
        {
            return new Point
            {
                X = v1,
                Y = v2
            };
        }
    }

    class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double DistanceTo(Point point)
        {
            var sideA = Math.Abs(X - point.X);
            var sideB = Math.Abs(Y - point.Y);
            var distance = Math.Sqrt(sideA * sideA + sideB * sideB);
            return distance;
        }
    }
}
