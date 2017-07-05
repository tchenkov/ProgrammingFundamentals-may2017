using System;
using System.Text.RegularExpressions;

namespace P05_OnlyLetters
{
    class P05_OnlyLetters
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = @"(?<digits>\d+)(?<ch>[A-Za-z])";
            var matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                text = text.Replace(
                    match.Groups["digits"].Value, match.Groups["ch"].Value);
            }

            Console.WriteLine(text);
        }
    }
}
