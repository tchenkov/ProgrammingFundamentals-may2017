using System;
using System.Linq;

namespace P04_TripleSum
{
    class P04_TripleSum
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();

            bool isThereASum = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    // solution #2
                    int sum = array[i] + array[j];
                    if (array.Contains(sum))
                    {
                        Console.WriteLine($"{array[i]} + {array[j]} == {sum}");
                        isThereASum = true;
                    }

                    // solution #1
                    //for (int k = 0; k < array.Length; k++)
                    //{
                    //    if (sum == array[k])
                    //    {
                    //        isThereASum = true;
                    //        Console.WriteLine($"{array[i]} + {array[j]} == {array[k]}");
                    //        break;
                    //    }
                    //}
                }
            }

            if (!isThereASum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
