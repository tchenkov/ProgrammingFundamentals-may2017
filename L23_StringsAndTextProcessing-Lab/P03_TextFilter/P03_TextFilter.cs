using System;

namespace P03_TextFilter
{
    class P03_TextFilter
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
            var text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                while (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));                    
                }
            }

            Console.WriteLine(text);
        }
    }
}
