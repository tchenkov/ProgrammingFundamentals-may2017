using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02_MatchPhoneNumber
{
    class P02_MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            var pattern = @"\+359( |\-)[2]\1\d{3}\1\d{4}\b";
            var text = Console.ReadLine();
            var matches = Regex.Matches(text, pattern);
            var phoneNumbersList = matches.Cast<Match>()
                .Select(ph => ph.Value)
                .ToList();
            Console.WriteLine(string.Join(", ", phoneNumbersList));
        }
    }
}
