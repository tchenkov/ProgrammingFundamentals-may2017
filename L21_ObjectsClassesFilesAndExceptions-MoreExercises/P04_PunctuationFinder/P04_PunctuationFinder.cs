using System;
using System.Linq;
using System.IO;

namespace P04_PunctuationFinder
{
    class P04_PunctuationFinder
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText(@"C:\Users\todor\Desktop\sample_text.txt");
            var result = text.ToCharArray().Where(c => new char[] { '.', ',', '!', '?', ':' }.Contains(c)).ToList();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
