using System;
using System.Linq;

namespace P02_RandomizeWords
{
    class P02_RandomizeWords
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var wordsList = Console.ReadLine()
                .Split(' ')
                .ToList();
            var wordsCount = wordsList.Count;
            for (int i = 0; i < wordsCount - 1; i++)
            {
                int j = rand.Next(0, wordsCount);
                if (i != j)
                {
                    var old = wordsList[i];
                    wordsList[i] = wordsList[j];
                    wordsList[j] = old;
                }
            }

            foreach (var word in wordsList)
            {
                Console.WriteLine(word);
            }
        }
    }
}
