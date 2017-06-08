using System;

namespace P05_FibonacciNumbers
{
    class P05_FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int fibMinus2 = 0;
            int fibMinus1 = 1;
            int fibonadcciN = 1;
            for (int i = 0; i < number; i++)
            {
                fibonadcciN = fibMinus2 + fibMinus1;
                fibMinus2 = fibMinus1;
                fibMinus1 = fibonadcciN;
            }

            Console.WriteLine(fibonadcciN);
        }
    }
}
