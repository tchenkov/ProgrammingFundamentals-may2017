using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P01_MatchFullName
{
    class P01_MatchFullName
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine();
            var matches = Regex.Matches(names, @"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            var namesList = new List<string>();
            foreach (Match name in matches)
            {
                namesList.Add($"{name}");
            }
            Console.WriteLine(string.Join(" ", namesList));
        }
    }
}
