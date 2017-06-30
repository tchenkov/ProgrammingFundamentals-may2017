using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace P03_WordCount
{
    class P03_WordCount
    {
        static void Main(string[] args)
        {
            var words = File.ReadAllText(@"C:\Users\todor\Desktop\words.txt").Split();
            var text = File.ReadAllText(@"C:\Users\todor\Desktop\input.txt")
                .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' },
                StringSplitOptions.RemoveEmptyEntries);

            var shortestWordLenght = words.OrderBy(w => w.Length).First().Length;
            var textLenght = text.Length - shortestWordLenght;

            var selectedWordsCount = new Dictionary<string, int>();

            foreach (var word in text)
            {
                foreach (var match in words)
                {
                    if (!selectedWordsCount.ContainsKey(match))
                    {
                        selectedWordsCount[match] = 0;
                    }
                    if (string.Equals(word, match, StringComparison.InvariantCultureIgnoreCase))
                    {
                        selectedWordsCount[match]++;
                    }
                }
            }

            selectedWordsCount = selectedWordsCount
                .OrderByDescending(c => c.Value)
                .ToDictionary(k => k.Key, v => v.Value);
            var outputtext = selectedWordsCount.Select(word => $"{word.Key} - {word.Value}").ToList();
            File.WriteAllLines(@"C:\Users\todor\Desktop\output.txt", outputtext);
        }
    }
}
