using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Palindromes
{
    class P04_Palindromes
    {
        static void Main(string[] args)
        {
            var wordsArray = Console.ReadLine()
                .Split(new char[] { ' ', ',', '.', '?', '!' },
                StringSplitOptions.RemoveEmptyEntries);

            var palindromesList = new List<string>();

            foreach (var word in wordsArray)
            {
                var reversedWord = new string(word.Reverse().ToArray());
                if (word == reversedWord && !palindromesList.Contains(word))
                {
                    palindromesList.Add(word);
                }
            }

            palindromesList = palindromesList.OrderBy(w => w).ToList();
            Console.WriteLine(string.Join(", ", palindromesList));
        }
    }
}
