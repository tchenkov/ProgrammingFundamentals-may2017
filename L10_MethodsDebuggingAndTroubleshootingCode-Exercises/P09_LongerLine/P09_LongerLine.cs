using System;

namespace P09_LongerLine
{
    class P09_LongerLine
    {
        static void Main(string[] args)
        {
            var line1 = InputLineCoordinates();
            var line2 = InputLineCoordinates();
            var biggerLine = GetBiggerLineCoordinates(line1, line2);
            Console.WriteLine(LineString(biggerLine));

        }

        static string LineString(double[] biggerLine)
        {
            double point1Distance = biggerLine[0] * biggerLine[0] + biggerLine[1] * biggerLine[1];
            double point2Distance = biggerLine[2] * biggerLine[2] + biggerLine[3] * biggerLine[3];
            var result =
                point1Distance <= point2Distance ?
                    $"({biggerLine[0]}, {biggerLine[1]})({biggerLine[2]}, {biggerLine[3]})" :
                    $"({biggerLine[2]}, {biggerLine[3]})({biggerLine[0]}, {biggerLine[1]})"
                ;
            return result;
        }

        static double[] InputLineCoordinates()
        {
            var coordinates = new double[4];
            for (int i = 0; i < 4; i++)
            {
                coordinates[i] = double.Parse(Console.ReadLine());
            }
            return coordinates;
        }

        static double[] GetBiggerLineCoordinates(double[] line1, double[] line2)
        {
            var line1Lenght = GetLineLenght(line1);
            var line2Lenght = GetLineLenght(line2);
            var biggerLine = line1Lenght >= line2Lenght ?
                line1 :
                line2;
            return biggerLine;
        }

        static double GetLineLenght(double[] line)
        {
            var x = Math.Max(line[0], line[2]) - Math.Min(line[0], line[2]);
            var y = Math.Max(line[1], line[3]) - Math.Min(line[1], line[3]);
            return Math.Sqrt(x * x + y * y);
        }
    }
}
