using System;
using System.Text.RegularExpressions;

namespace P02_ExtractSentencesByKeyword
{
    class P02_ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();
            var sentencePattern = @"(^|(?<=\s))[A-Z][^.!?]*\W" + word + @"\W.*?(?=[\.\?\!])";
            var sentencesMatches = Regex.Matches(text, sentencePattern);
            foreach (Match sentence in sentencesMatches)
            {
                Console.WriteLine(sentence.Value);
            }
        }
    }
}
