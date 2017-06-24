using System;
using System.Linq;

namespace P06_ByteFlip
{
    class P06_ByteFlip
    {
        static void Main(string[] args)
        {
            var messageCode = Console.ReadLine()
                .Split(' ')
                .Where(x => x.Length == 2)
                .Select(x => new string(x.Reverse().ToArray()))
                .Select(x => Convert.ToChar(Convert.ToInt32(x, 16)))
                .Reverse()
                .ToList();
            Console.WriteLine(string.Join(null ,messageCode));
        }
    }
}
