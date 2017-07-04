using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P05_KeyReplacer
{
    class P05_KeyReplacer
    {
        static void Main(string[] args)
        {
            var keyString = Console.ReadLine();

            var startPattern = @"^[A-Za-z]+(?=[<\|\\])";
            var endPattern = @"(?<=[<\|\\])[A-Za-z]+(?=$)";
            var start = Regex.Match(keyString, startPattern).Value;
            var end = Regex.Match(keyString, endPattern).Value;

            var text = Console.ReadLine();

            var pattern = $"(?<={start})(?!{start}|{end}).*?(?={end})";
            var matches = Regex.Matches(text, pattern);

            var matchesList = matches
                .Cast<Match>()
                .Select(m => m.Value)
                .ToList();
            Console.WriteLine(
                matchesList.Count == 0 ?
                "Empty result" :
                string.Join("", matchesList)
            );
        }
    }
}
