using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_MagicExchangeableWords
{
    class P05_MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split();
            var firstWord = words[0];
            var secondWord = words[1];
            bool isMagic = true;
            var length = firstWord.Length < secondWord.Length ?
                firstWord.Length :
                secondWord.Length;
            if (firstWord.Distinct().ToList().Count != secondWord.Distinct().ToList().Count)
            {
                Console.WriteLine("false");
                return;
            }

            var map = new Dictionary<char, char>();
            for (int i = 0; i < length; i++)
            {
                var key = firstWord[i];
                var value = secondWord[i];
                if (!map.ContainsKey(key))
                {
                    map[key] = value;
                }
                else if (map[key] != value)
                {
                    isMagic = false;
                    break;
                }
            }
            
            if (firstWord.Length < secondWord.Length)
            {
                for (int i = firstWord.Length; i < secondWord.Length; i++)
                {
                    var value = secondWord[i];
                    if (!map.ContainsValue(value))
                    {
                        isMagic = false;
                        break;
                    }
                }
            }
            else
            {
                for (int i = secondWord.Length; i < firstWord.Length; i++)
                {
                    var key = firstWord[i];
                    if (!map.ContainsKey(key))
                    {
                        isMagic = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isMagic ? "true" : "false");
        }
    }
}
