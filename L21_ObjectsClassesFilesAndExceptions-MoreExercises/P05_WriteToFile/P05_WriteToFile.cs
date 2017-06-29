using System;
using System.IO;
using System.Linq;

namespace P05_WriteToFile
{
    class P05_WriteToFile
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText(@"C:\Users\todor\Desktop\sample_text.txt");
            var result = text.ToCharArray().Where(c => !(new char[] { '.', ',', '!', '?', ':' }.Contains(c))).ToList();
            Console.WriteLine(string.Join("", result));
        }
    }
}
