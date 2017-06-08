using System;

namespace P06_MathPower
{
    class P06_MathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double poweredNumber = GetNumberPowerOf(number, power);
            Console.WriteLine(poweredNumber);
        }

        static double GetNumberPowerOf(double number, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
