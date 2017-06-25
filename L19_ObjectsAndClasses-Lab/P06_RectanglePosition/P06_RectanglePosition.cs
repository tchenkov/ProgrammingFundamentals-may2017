using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_RectanglePosition
{
    class P06_RectanglePosition
    {
        static void Main(string[] args)
        {
            List<Rectangle> rectangles = GetRectangles();

            bool isFirstRectInSedondRect = rectangles[1].IsInsede(rectangles[0]);

            Console.WriteLine(
                isFirstRectInSedondRect ?
                "Inside" :
                "Not inside"
            );
        }

        static List<Rectangle> GetRectangles()
        {
            var rectnaglesCount = 2;
            var rectangles = new List<Rectangle>();
            for (int i = 0; i < rectnaglesCount; i++)
            {
                var rectangleData = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                rectangles.Add(
                    new Rectangle
                    {
                        Left = rectangleData[0],
                        Top = rectangleData[1],
                        Width = rectangleData[2],
                        Height = rectangleData[3]
                    }
                );
            }

            return rectangles;
        }
    }

    class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        public bool IsInsede(Rectangle rectange)
            => Left <= rectange.Left && rectange.Right <= Right &&
                Top <= rectange.Top && Bottom >= rectange.Bottom;
    }
}
