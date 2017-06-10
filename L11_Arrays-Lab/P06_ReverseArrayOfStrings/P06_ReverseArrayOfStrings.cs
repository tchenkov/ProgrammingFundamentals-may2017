using System;
using System.Linq;

namespace P06_ReverseArrayOfStrings
{
    class P06_ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] inputStrArrReverced = Console.ReadLine()
                .Split(' ')
                .ToArray()
                .Reverse()
                .ToArray();
            Console.WriteLine(string.Join(" ", inputStrArrReverced));
        }
    }
}
