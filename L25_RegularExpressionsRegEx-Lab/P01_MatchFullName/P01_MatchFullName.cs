using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P01_MatchFullName
{
    class P01_MatchFullName
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine();
            var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            var matches = Regex.Matches(names, pattern);
            var namesArr = matches.Cast<Match>().Select(m => m.ToString()).ToArray();
            Console.WriteLine(string.Join(" ", namesArr));
        }
    }
}
