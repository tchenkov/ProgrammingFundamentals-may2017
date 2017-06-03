using System;

namespace P15_FastPrimeChecker
{
    class P15_FastPrimeChecker
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            for (int currentNumber = 2; currentNumber <= numbersCount; currentNumber++)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(currentNumber); i++)
                {
                    if (currentNumber % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNumber} -> {isPrime}");
            }

        }
    }
}
