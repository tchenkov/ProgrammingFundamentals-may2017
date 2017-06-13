using System;

namespace P09_IndexOfLetters
{
    class P09_IndexOfLetters
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().ToLower();
            var chars = new char['z' - 'a' + 1];
            for (int i = 'a'; i <= 'z'; i++)
            {
                chars[i - 'a'] = (char)i;                
            }
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{word[i]} -> {Array.IndexOf(chars, word[i])}");
            }
        }
    }
}
