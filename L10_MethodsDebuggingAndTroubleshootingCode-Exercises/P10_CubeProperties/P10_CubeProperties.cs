using System;

namespace P10_CubeProperties
{
    class P10_CubeProperties
    {
        static void Main(string[] args)
        {
            var qubeEdgeLenght = double.Parse(Console.ReadLine());
            var qubeProperty = Console.ReadLine();
            double result = 0;
            switch (qubeProperty)
            {
                case "face":
                    result = GetQbreFaceDiagonal(qubeEdgeLenght);
                    break;
                case "space":
                    result = GetQubeSpaceDiagonal(qubeEdgeLenght);
                    break;
                case "volume":
                    result = GetQubeVolume(qubeEdgeLenght);
                    break;
                case "area":
                    result = GetQubeArea(qubeEdgeLenght);
                    break;
            }
            Console.WriteLine($"{result:f2}");
        }

        private static double GetQubeSpaceDiagonal(double qubeEdgeLenght)
        {
            var faceDiagonal = GetQbreFaceDiagonal(qubeEdgeLenght);
            return Math.Sqrt(faceDiagonal * faceDiagonal + qubeEdgeLenght * qubeEdgeLenght);
        }

        private static double GetQbreFaceDiagonal(double qubeEdgeLenght)
        {
            return Math.Sqrt(qubeEdgeLenght * qubeEdgeLenght * 2);
        }

        static double GetQubeVolume(double qubeEdgeLenght)
        {
            return qubeEdgeLenght * qubeEdgeLenght * qubeEdgeLenght;
        }

        static double GetQubeArea(double qubeEdgeLenght)
        {
            return qubeEdgeLenght * qubeEdgeLenght * 6;
        }
    }
}
