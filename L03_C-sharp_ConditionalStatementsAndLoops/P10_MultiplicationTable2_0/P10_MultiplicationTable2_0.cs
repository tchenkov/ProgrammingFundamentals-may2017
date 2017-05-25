using System;

namespace P10_MultiplicationTable2_0
{
    class P10_MultiplicationTable2_0
    {
        static void Main(string[] args)
        {
            var number = byte.Parse(Console.ReadLine());
            var multiplier = byte.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
                multiplier++;
            } while (multiplier <= 10);
        }
    }
}
