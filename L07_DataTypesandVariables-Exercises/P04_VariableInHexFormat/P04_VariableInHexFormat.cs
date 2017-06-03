using System;

namespace P04_VariableInHexFormat
{
    class P04_VariableInHexFormat
    {
        static void Main(string[] args)
        {
            var num = Convert.ToInt32(Console.ReadLine(), 16);
            Console.WriteLine(num);
        }
    }
}
