using System;

namespace P09_RefactorSpecialNumbers
{
    class P09_RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numbersCount; i++)
            {
                int numDigitsSum = SumOfDigits(i);

                bool isNumSpecial = (numDigitsSum == 5) || (numDigitsSum == 7) || (numDigitsSum == 11);
                Console.WriteLine("{0} -> {1}", i, isNumSpecial);
            }
        }

        static int SumOfDigits(int i)
        {
            int numDigitsSum = 0;
            while (i > 0)
            {
                numDigitsSum += i % 10;
                i /= 10;
            }

            return numDigitsSum;
        }
    }
}
