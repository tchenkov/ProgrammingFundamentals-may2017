using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03_MatchHexadecimalNumbers
{
    class P03_MatchHexadecimalNumbers
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(0x)?[0-9A-F]+\b";
            var text = Console.ReadLine();
            var matches = Regex.Matches(text, pattern);
            var hexNums = matches
                .Cast<Match>()
                .Select(hex => hex.Value)
                .ToArray();
            Console.WriteLine(string.Join(" ", hexNums));
        }
    }
}
