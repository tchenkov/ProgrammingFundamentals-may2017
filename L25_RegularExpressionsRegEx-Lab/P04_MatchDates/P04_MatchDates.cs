using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P04_MatchDates
{
    class P04_MatchDates
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = 
                @"\b(?<day>\d{1,2})(?<dateSeparator>\/|\.|-)(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b";

            var dates = Regex.Matches(text, pattern);
            foreach (Match date in dates)
            {
                Console.WriteLine(
                    $"Day: {date.Groups["day"]}, Month: {date.Groups["month"]}, Year: {date.Groups["year"]}");
            }
        }
    }
}
