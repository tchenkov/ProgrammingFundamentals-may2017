using System;

namespace P05_SpecialNumbers
{
    class P05_SpecialNumbers
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numbersCount; i++)
            {
                int currentNumDigitSum = SumOfDigits(i);
                bool isCurrentNumSpecial = currentNumDigitSum == 5 || currentNumDigitSum == 7 || currentNumDigitSum == 11;
                Console.WriteLine($"{i} -> {isCurrentNumSpecial}");
            }
        }

        static int SumOfDigits(int number)
        {
            int sum = 0;
            do
            {
                sum += number % 10;
                number /= 10;
            } while (number > 0);
            return sum;
        }
    }
}
