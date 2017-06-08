using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_PrimesInGivenRange
{
    class P07_PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            List<int> primeNumbers = GetPrimesInInterval(number1, number2);
            Console.WriteLine(string.Join(", ", primeNumbers));
        }
        
        static List<int> GetPrimesInInterval(int startNum, int endNum)
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
            startNum = startNum < 2 ? 2 : startNum;
            for (int i = startNum; i < isPrime.Length; i++)
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
