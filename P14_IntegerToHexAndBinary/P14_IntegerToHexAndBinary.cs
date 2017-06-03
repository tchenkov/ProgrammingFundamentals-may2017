using System;

namespace P14_IntegerToHexAndBinary
{
    class P14_IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(num, 16).ToUpper());
            Console.WriteLine(Convert.ToString(num, 2));
        }
    }
}
