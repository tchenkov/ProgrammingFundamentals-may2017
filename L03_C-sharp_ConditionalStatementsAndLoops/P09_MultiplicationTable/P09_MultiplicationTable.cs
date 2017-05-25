using System;

namespace P09_MultiplicationTable
{
    class P09_MultiplicationTable
    {
        static void Main(string[] args)
        {
            var number = byte.Parse(Console.ReadLine());
            for (byte i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }
        }
    }
}
