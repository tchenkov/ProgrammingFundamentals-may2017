using System;
using System.Linq;

namespace P01_LargestCommonEnd
{
    class P01_LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine()
                .Split(' ')
                .ToArray();
            string[] array2 = Console.ReadLine()
                .Split(' ')
                .ToArray();
            string[] biggerArray = array1.Length >= array2.Length ? array1 : array2;
            string[] smallerArray = array1.Length < array2.Length ? array1 : array2;

            int arraysLenghtDifference = biggerArray.Length - smallerArray.Length;
            int forwardCounter = CountStartingEqualElements(biggerArray, smallerArray, arraysLenghtDifference);
            Array.Reverse(biggerArray);
            Array.Reverse(smallerArray);
            int backwardCounter = CountStartingEqualElements(biggerArray, smallerArray, arraysLenghtDifference);
            
            Console.WriteLine(
                forwardCounter >= backwardCounter ?
                forwardCounter :
                backwardCounter
                );
        }

        static int CountStartingEqualElements(string[] biggerArray, string[] smallerArray, int arraysLenghtDifference)
        {
            int counter = 0;
            for (int i = 0; i < biggerArray.Length - arraysLenghtDifference; i++)
            {
                if (biggerArray[i] == smallerArray[i])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            return counter;
        }
    }
}
