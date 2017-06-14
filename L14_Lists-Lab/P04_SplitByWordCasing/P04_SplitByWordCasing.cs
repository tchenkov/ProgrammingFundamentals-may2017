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
                bool upperCase = false;
                bool lowerCase = false;
                bool otherChar = false;
                foreach (var symbol in wordsList[i])
                {
                    if ('A' <= symbol && symbol <= 'Z')
                    {
                        upperCase = true;
                    }
                    else if ('a' <= symbol && symbol <= 'z')
                    {
                        lowerCase = true;
                    }
                    else if (!('A' <= symbol && symbol <= 'z'))
                    {
                        otherChar = true;
                    }
                }

                if (lowerCase && !upperCase && !otherChar)
                {
                    wordsLowerCase.Add(wordsList[i]);
                }
                else if (upperCase && !lowerCase && !otherChar)
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
    }
}
