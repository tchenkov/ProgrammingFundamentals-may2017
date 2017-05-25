using System;

namespace P12_NumberChecker
{
    class P12_NumberChecker
    {
        static void Main(string[] args)
        {
            try
            {
                double.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
