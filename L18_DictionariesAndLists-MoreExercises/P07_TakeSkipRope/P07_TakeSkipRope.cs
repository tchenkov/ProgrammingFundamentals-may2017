using System;
using System.Linq;

namespace P07_TakeSkipRope
{
    class P07_TakeSkipRope
    {
        static void Main(string[] args)
        {
            var rawMessage = Console.ReadLine()
                .ToCharArray()
                .ToList();
            var message = rawMessage
                .Where(x => !IsDigit(x))
                .ToList();
            var numList = rawMessage
                .Where(x => IsDigit(x))
                .Select(x => int.Parse(x.ToString()))
                .ToList();
            var takeList = numList
                .Where((x, i) => i % 2 == 0)
                .ToList();
            var skipList = numList
                .Where((x, i) => i % 2 == 1)
                .ToList();
            string result = string.Empty;
            foreach (var item in takeList.Zip(skipList, Tuple.Create))
            {
                result += string.Join(null, message.Select(x => x).Take(item.Item1));
                message = message.Skip(item.Item1 + item.Item2).ToList();
            }
            Console.WriteLine(result);
        }

        static bool IsDigit(char symbol)
            => '0' <= symbol && symbol <= '9';        
    }
}
