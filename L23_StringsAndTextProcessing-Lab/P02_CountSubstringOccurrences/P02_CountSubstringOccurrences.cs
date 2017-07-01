using System;

namespace P02_CountSubstringOccurrences
{
    class P02_CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var substring = Console.ReadLine().ToLower();

            var count = 0;
            var index = 0;
          
            while (index != -1)
            {
                index = text.IndexOf(substring, index);
                if (index >= 0)
                {
                    count++;
                    index++;
                }                
            }

        Console.WriteLine(count);
        }
    }
}
