using System;
using System.Text.RegularExpressions;

namespace P04_MorseCodeUpgraded
{
    class P04_MorseCodeUpgraded
    {
        static void Main(string[] args)
        {
            var inputCodes = Console.ReadLine()
                .Split('|');
            var message = string.Empty;
            
            foreach (var code in inputCodes)
            {
                var sum = 0;
                var matches = Regex.Matches(code, @"([\d])(\1+)?");
                foreach (Match match in matches)
                {
                    var matchStr = match.Value;
                    sum += matchStr.Length > 1 ?
                        matchStr.Length :
                        0;
                    sum += matchStr.StartsWith("0") ?
                        matchStr.Length * 3 :
                        matchStr.Length * 5;
                }
                message += (char) sum;
            }

            Console.WriteLine(message);
        }
    }
}
