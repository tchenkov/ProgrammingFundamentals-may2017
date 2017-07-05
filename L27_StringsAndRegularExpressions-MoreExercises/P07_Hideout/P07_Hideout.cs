using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P07_Hideout
{
    class P07_Hideout
    {
        static void Main(string[] args)
        {
            var map = Console.ReadLine();
            var isClueFound = false;
            while (!isClueFound)
            {
                var specialChars = @"/.*+?|(,)[]{}\";
                var clue = Console.ReadLine().Split();
                var clueChar = clue.First();
                clueChar = specialChars.Contains(clueChar) ?
                    @"\"+clueChar :
                    clueChar;
                var minCount = int.Parse(clue.Last());
                var match = Regex.Match(map, $"[{clueChar}]{{{minCount},}}");
                isClueFound = match.Success;
                if (isClueFound)
                {
                    var index = match.Index;
                    var length = match.Value.Length;

                    Console.WriteLine($"Hideout found at index {index} and it is with size {length}!");
                }
            }
        }
    }
}
