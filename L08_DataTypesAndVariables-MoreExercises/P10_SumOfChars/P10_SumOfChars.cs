using System;

namespace P10_SumOfChars
{
    class P10_SumOfChars
    {
        static void Main(string[] args)
        {
            byte charsCount = byte.Parse(Console.ReadLine());
            int sum = 0;
            while (charsCount > 0)
            {
                sum += char.Parse(Console.ReadLine());
                charsCount--;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
