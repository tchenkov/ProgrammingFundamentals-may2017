using System;
using System.Text.RegularExpressions;

namespace P08_Mines
{
    class P08_Mines
    {
        static void Main(string[] args)
        {
            var mineField = Console.ReadLine();
            var pattern = "<(?<first>.)(?<second>.)>";
            var matches = Regex.Matches(mineField, pattern);
            foreach (Match mine in matches)
            {
                var firstChar = mine.Groups["first"].Value;
                var secondChar = mine.Groups["second"].Value;
                var blastRadius = Math.Abs(firstChar[0] - secondChar[0]);
                pattern = MinesPattern(blastRadius, firstChar, secondChar);
                var match = Regex.Match(mineField, pattern).Value;
                mineField = mineField.Replace(match, new string('_', match.Length));
            }

            Console.WriteLine(mineField);
        }

        static string MinesPattern(int blastRadius, string firstChar, string secondChar)
        {
            var specialChars = @"/.*+?|(,)[]{}\";
            firstChar = specialChars.Contains(firstChar) ? @"\" + firstChar : firstChar;
            secondChar = specialChars.Contains(secondChar) ? @"\" + secondChar : secondChar;
            return $".{{0,{blastRadius}}}<(?<first>{firstChar})(?<second>{secondChar})>.{{0,{blastRadius}}}";
        }
    }
}
