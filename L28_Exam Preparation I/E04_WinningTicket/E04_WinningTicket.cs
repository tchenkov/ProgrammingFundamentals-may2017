using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace E04_WinningTicket
{
    class E04_WinningTicket
    {
        static void Main(string[] args)
        {
            var tickets = Regex.Matches(Console.ReadLine(), @"[^\s,]+" );
            var ticketsChecked = new List<Match>();
            foreach (Match ticket in tickets)
            {
                var match = Regex.Match(ticket.Value, @"^(?<left>.{10})(?<right>.{10})$");
                ticketsChecked.Add(match);
            }

            foreach (Match ticket in ticketsChecked)
            {
                if (!ticket.Success)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                var match = Regex.Match(ticket.Value, @"^(@|#|\$|\^)\1{19}$");
                if (match.Success)
                {
                    Console.WriteLine($"ticket \"{ticket.Value}\" - 10{ticket.Value[0]} Jackpot!");
                    continue;
                }
                var pattern = @"(?<symbol>[@]|[#]|[\$]|[\^])\1{5,}";
                var leftHalfMatch = Regex.Match(ticket.Value.Substring(0,10), pattern);
                var rightHalfMatch = Regex.Match(ticket.Value.Substring(10, 10), pattern);
                if (leftHalfMatch.Success && rightHalfMatch.Success &&
                    leftHalfMatch.Groups["symbol"].Value == rightHalfMatch.Groups["symbol"].Value)
                {
                    var length = Math.Min(leftHalfMatch.Length, rightHalfMatch.Length);
                    var symbol = leftHalfMatch.Groups["symbol"].Value;
                    Console.WriteLine($"ticket \"{ticket.Value}\" - {length}{symbol}");
                    continue;
                }

                Console.WriteLine($"ticket \"{ticket.Value}\" - no match");

            }
        }
    }
}
