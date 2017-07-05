using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P06_EmailStatistics
{
    class P06_EmailStatistics
    {
        static void Main(string[] args)
        {
            var validEMailList = GetValidEMails();
            var orderedEMails = OrderByDomain(validEMailList);
            PrintEMails(orderedEMails);
        }

        static void PrintEMails(Dictionary<string, List<string>> orderedEMails)
        {
            foreach (var domain in orderedEMails)
            {
                Console.WriteLine($"{domain.Key}:");
                foreach (var username in domain.Value)
                {
                    Console.WriteLine($"### {username}");
                }
            }
        }

        static Dictionary<string, List<string>> OrderByDomain(List<Match> validEMailList)
        {
            var orderedEMails = new Dictionary<string, List<string>>();

            foreach (Match eMail in validEMailList)
            {
                var username = eMail.Groups["username"].Value;
                var domain = eMail.Groups["domain"].Value;
                if (!orderedEMails.ContainsKey(domain))
                {
                    orderedEMails[domain] = new List<string>();
                }
                if (!orderedEMails[domain].Contains(username))
                {
                    orderedEMails[domain].Add(username);
                }
            }

            orderedEMails = orderedEMails
                .OrderByDescending(u => u.Value.Count)
                .ToDictionary(k => k.Key, v => v.Value);
            return orderedEMails;
        }

        private static List<Match> GetValidEMails()
        {
            var validEMailList = new List<Match>();
            var entriesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < entriesCount; i++)
            {
                var inputText = Console.ReadLine();
                var eMailPattern =
                    @"^(?<username>[A-Za-z]{5,})@(?<domain>[a-z]{3,}\.(?:com|bg|org))$";
                var match = Regex.Match(inputText, eMailPattern);
                if (match.Success)
                {
                    validEMailList.Add(match);
                }
            }
            return validEMailList;
        }
    }
}
