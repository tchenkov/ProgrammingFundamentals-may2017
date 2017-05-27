using System;

namespace P14_MagicLetter
{
    class P14_MagicLetter
    {
        static void Main(string[] args)
        {
            var startChar = char.Parse(Console.ReadLine());
            var endChar = char.Parse(Console.ReadLine());
            var invalidChar = char.Parse(Console.ReadLine());

            for (char i = startChar; i <= endChar; i++)
            {
                if (i == invalidChar)
                {
                    continue;
                }
                for (char j = startChar; j <= endChar; j++)
                {
                    if (j == invalidChar)
                    {
                        continue;
                    }
                    for (char k = startChar; k <= endChar; k++)
                    {
                        if (k == invalidChar)
                        {
                            continue;
                        }
                        Console.Write($"{i}{j}{k} ");
                    }
                }
            }
        }
    }
}
