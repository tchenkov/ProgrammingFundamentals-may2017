using System;
using System.Text.RegularExpressions;

namespace P01_Censorship
{
    class P01_Censorship
    {
        static void Main(string[] args)
        {
            var keyWord = Console.ReadLine();
            var text = Console.ReadLine();
            text = Regex.Replace(text, keyWord, new string('*', keyWord.Length));
            Console.WriteLine(text);
        }
    }
}
