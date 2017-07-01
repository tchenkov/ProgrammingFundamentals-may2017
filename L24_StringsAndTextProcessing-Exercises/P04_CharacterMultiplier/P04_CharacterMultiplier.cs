using System;
using System.Linq;

namespace P04_CharacterMultiplier
{
    class P04_CharacterMultiplier
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().OrderBy(s => s.Length).ToArray();
            var str1 = input[0];
            var str2 = input[1];

            var result = 0;
            for (int i = 0; i < str2.Length; i++)
            {
                if (i < str1.Length)
                {
                    result += str1[i] * str2[i];
                }
                else
                {
                    result += str2[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
