using System;
using System.Linq;

namespace P01_ReverseString
{
    class P01_ReverseString
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var strReversed = new string(str.Reverse().ToArray());
            Console.WriteLine(strReversed);
        }
    }
}
