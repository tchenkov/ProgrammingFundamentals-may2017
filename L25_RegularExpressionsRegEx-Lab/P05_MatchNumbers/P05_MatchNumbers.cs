using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P05_MatchNumbers
{
    class P05_MatchNumbers
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var matches = Regex.Matches(text, pattern);
            var numArr = matches
                .Cast<Match>()
                .Select(n => n.Value)
                .ToArray();
            Console.WriteLine(string.Join(" ", numArr));

        }
    }
}
