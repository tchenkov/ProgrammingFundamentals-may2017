using System;

namespace P15_Substring
{
    class P15_Substring
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            const char magicLetter = 'p';
            bool hasMatch = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == magicLetter)
                {
                    hasMatch = true;
                    int endIndex = count + 1 > text.Length - i ? text.Length - i : count + 1;
                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += count;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
