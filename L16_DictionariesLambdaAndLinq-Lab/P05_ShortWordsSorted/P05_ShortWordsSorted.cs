using System;
using System.Linq;

namespace P05_ShortWordsSorted
{
    class P05_ShortWordsSorted
    {
        static void Main(string[] args)
        {
            var separators = new char[] {'.',',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' '};
            var wordsList = Console.ReadLine()
                .ToLower()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .ToList();
            Console.WriteLine(string.Join(", ", wordsList));
        }
    }
}
