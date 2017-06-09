using System;
using System.Collections.Generic;
using System.Linq;

namespace P12_MasterNumber
{
    class P12_MasterNumber
    {
        static void Main(string[] args)
        {
            int maxMasterNumber = int.Parse(Console.ReadLine());
            PrintMasterNumbersUpTo(maxMasterNumber);
        }

        private static void PrintMasterNumbersUpTo(int maxMasterNumber)
        {
            for (int currentNumber = 232; currentNumber <= maxMasterNumber; currentNumber++)
            {
                if (!IsPalindrome(currentNumber))
                {
                    continue;
                }
                if (!IsSumOfDigitsDivisibleBy7(currentNumber))
                {
                    continue;
                }
                if (!IsNumHavingEvenDigit(currentNumber))
                {
                    continue;
                }
                Console.WriteLine(currentNumber);
            }
        }

        static bool IsNumHavingEvenDigit(int number)
        {
            foreach (var digit in IntToDigitsArray(number))
            {
                if (digit % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        static bool IsSumOfDigitsDivisibleBy7(int number)
        {
            int sum = IntToDigitsArray(number).Sum();
            return sum % 7 == 0;
        }

        static bool IsPalindrome(int number)
        {
            string digits = number.ToString();
            for (int i = 0; i < digits.Length - 1 / 2; i++)
            {
                if (digits[i] != digits[digits.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static int[] IntToDigitsArray(int number)
        {
            List<int> digitsList = new List<int>();
            while (number > 0)
            {
                digitsList.Add(number % 10);
                number /= 10;
            }
            return digitsList.ToArray();
        }
    }
}
