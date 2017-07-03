using System;
using System.Text.RegularExpressions;

namespace P04_MatchDates
{
    class P04_MatchDates
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = 
                @"\b(?<day>\d{2})(?<dateSeparator>\/|\.|-)(?<month>[A-Z][a-z]{2})\k<dateSeparator>(?<year>\d{4})\b";

            var dates = Regex.Matches(text, pattern);
            foreach (Match date in dates)
            {
                Console.WriteLine(
                    $"Day: {date.Groups["day"]}, Month: {date.Groups["month"]}, Year: {date.Groups["year"]}");
            }
        }
    }
}
