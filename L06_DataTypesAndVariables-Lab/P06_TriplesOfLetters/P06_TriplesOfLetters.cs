using System;

namespace P06_TriplesOfLetters
{
    class P06_TriplesOfLetters
    {
        static void Main(string[] args)
        {
            int lettersCount = int.Parse(Console.ReadLine()) + 'a';

            for (char i = 'a'; i < lettersCount; i++)
            {
                for (char j = 'a'; j < lettersCount; j++)
                {
                    for (char k = 'a'; k < lettersCount; k++)
                    {
                        string lettersString = "" + i + j + k;
                        Console.WriteLine(lettersString);
                    }
                }
            }
        }
    }
}
