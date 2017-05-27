using System;

namespace P06_IntervalOfNumbers
{
    class P06_IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            var number1 = byte.Parse(Console.ReadLine());
            var number2 = byte.Parse(Console.ReadLine());
            var smallerNumber = Math.Min(number1, number2);
            var biggerNumber = Math.Max(number1, number2);

            for (int i = smallerNumber; i <= biggerNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
