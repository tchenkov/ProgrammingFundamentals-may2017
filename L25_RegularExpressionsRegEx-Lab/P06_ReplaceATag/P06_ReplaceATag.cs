using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P06_ReplaceATag
{
    class P06_ReplaceATag
    {
        static void Main(string[] args)
        {
            var text = new List<string>();
            var addText = Console.ReadLine();
            while (addText != "end")
            {
                text.Add(addText);
                addText = Console.ReadLine();
            }

            foreach (var line in text)
            {
                var pattern = @"<a.*?href=""(?<url>.*?)"".*?>(?<text>.*?)<\/a>";
                var replacePattern = @"[URL href=""${url}""]${text}[/URL]";
                var replacedText = Regex.Replace(line, pattern, replacePattern);
                Console.WriteLine(replacedText);
            }
        }
    }
}
