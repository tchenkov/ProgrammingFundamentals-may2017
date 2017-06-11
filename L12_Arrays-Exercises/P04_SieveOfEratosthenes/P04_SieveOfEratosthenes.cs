using System;
using System.Collections.Generic;

namespace P04_SieveOfEratosthenes
{
    class P04_SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            List<int> primeNumbers = GetPrimesInInterval(number);
            Console.WriteLine(string.Join(" ", primeNumbers));
        }

        static List<int> GetPrimesInInterval(int endNum)
        {
            bool[] isPrime = new bool[endNum + 1];
            for (int i = 0; i < isPrime.Length; i++)
            {
                isPrime[i] = true;
            }
            for (int i = 2; i <= endNum; i++)
            {
                if (isPrime[i])
                {
                    int j = i + i;
                    while (j <= endNum)
                    {
                        isPrime[j] = false;
                        j += i;
                    }
                }
            }

            List<int> listOfPrimeNumbers = new List<int>();
            
            for (int i = 2; i < isPrime.Length; i++)
            {
                if (isPrime[i])
                {
                    listOfPrimeNumbers.Add(i);
                }
            }

            return listOfPrimeNumbers;
        }
    }
}
