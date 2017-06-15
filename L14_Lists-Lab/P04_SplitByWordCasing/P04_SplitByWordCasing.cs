using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_SplitByWordCasing
{
    class P04_SplitByWordCasing
    {
        static void Main(string[] args)
        {
            var separators = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            var wordsList = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
               .ToList();
            var wordsLowerCase = new List<string>();
            var wordsMixedCase = new List<string>();
            var wordsUpperCase = new List<string>();
            for (int i = 0; i < wordsList.Count; i++)
            {
                bool lowerCase = IsWordLowerCase(wordsList[i]);
                bool upperCase = IsWordUpperCase(wordsList[i]);
                               
                if (lowerCase)
                {
                    wordsLowerCase.Add(wordsList[i]);
                }
                else if (upperCase)
                {
                    wordsUpperCase.Add(wordsList[i]);
                }
                else
                {
                    wordsMixedCase.Add(wordsList[i]);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", wordsLowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", wordsMixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", wordsUpperCase)}");
        }

        static bool IsWordUpperCase(string word)
            => IsSymbolInInterval('A', 'Z', word);

        static bool IsWordLowerCase(string word)
            => IsSymbolInInterval('a', 'z', word);

        static bool IsSymbolInInterval(char startChar, char endChar, string word)
        {
            foreach (var symbol in word)
            {
                if (symbol < startChar || endChar < symbol)
                {
                    return false;
                }                
            }
            return true;
        }
    }
}
