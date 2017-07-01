using System;

namespace P03_UnicodeCharacters
{
    class P03_UnicodeCharacters
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var uniCode = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                var code = $"{(int)text[i]:X4}".ToLower();
                uniCode += $"\\u{code}";
            }

            Console.WriteLine(uniCode);
        }
    }
}
