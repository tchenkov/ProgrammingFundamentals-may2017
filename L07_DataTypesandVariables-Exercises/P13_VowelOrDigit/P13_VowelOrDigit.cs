using System;

namespace P13_VowelOrDigit
{
    class P13_VowelOrDigit
    {
        static void Main(string[] args)
        {
            var symbol = Console.ReadLine();
            try
            {
                int.Parse(symbol);
                Console.WriteLine("digit");
            }
            catch (Exception)
            {
                char letter = char.Parse(symbol);
                bool isLetterAVowel =
                    letter == 'a' ||
                    letter == 'o' ||
                    letter == 'u' ||
                    letter == 'e' ||
                    letter == 'i';
                Console.WriteLine(isLetterAVowel ? "vowel" : "other");
            }
        }
    }
}
