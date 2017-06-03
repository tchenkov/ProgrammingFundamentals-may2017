using System;

namespace P17_PrintPartOf_ASCII_Table
{
    class P17_PrintPartOf_ASCII_Table
    {
        static void Main(string[] args)
        {
            char startChar = (char) int.Parse(Console.ReadLine());
            char endChar = (char)int.Parse(Console.ReadLine());
            OutputCharInterval(startChar, endChar);
        }

        static void OutputCharInterval(char startChar, char endChar)
        {
            if (startChar < endChar)
            {
                Console.Write($"{startChar} ");
                OutputCharInterval((char)(startChar + 1), endChar);
            }
            else
            {
                Console.WriteLine($"{startChar}");
            }
        }
    }
}
