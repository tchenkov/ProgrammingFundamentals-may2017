using System;

namespace P06_StringsAndObjects
{
    class P06_StringsAndObjects
    {
        static void Main(string[] args)
        {
            var string1 = Console.ReadLine();
            var string2 = Console.ReadLine();
            string concatenated = String.Concat(string1, " ", string2);
            Console.WriteLine(concatenated);
        }
    }
}
