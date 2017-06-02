using System;

namespace P02_CircleArea
{
    class P02_CircleArea
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double area = pi * radius * radius;
            Console.WriteLine($"{area:F12}");
        }
    }
}
