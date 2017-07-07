using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace E03_RageQuit
{
    class E03_RageQuit
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine().ToUpper();
            var matches = Regex.Matches(inputString, @"(?<str>\D+)(?<count>\d+)");
            var sb = new StringBuilder();
            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    var message = match.Groups["str"].Value;
                    var count = int.Parse(match.Groups["count"].Value);
                    for (int i = 0; i < count; i++)
                    {
                        sb.Append(message);
                    }
                }
            }
            var result = sb.ToString();
            var uniqueSymbolsCount = result.Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueSymbolsCount}");
            Console.WriteLine(result);
        }
    }
}
