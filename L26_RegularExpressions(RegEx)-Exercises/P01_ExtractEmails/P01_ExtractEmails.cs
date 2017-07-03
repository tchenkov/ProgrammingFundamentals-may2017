using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace P01_ExtractEmails
{
    class P01_ExtractEmails
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            //var path = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\Desktop\");
            //var text = File.ReadAllText(path + "test.txt");
            var pattern = @"(^|(?<=\s))[A-Za-z]+([0-9]+)?([\._-][A-z0-9]+)?@\w+-?\w+(?:\.\w+)+";
            var eMailMatches = Regex.Matches(text, pattern);
            var eMailArr = eMailMatches.Cast<Match>()
                .Select(e => e.Value)
                .ToArray();
            Console.WriteLine(string.Join("\r\n", eMailArr));
        }
    }
}
