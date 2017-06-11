using System;
using System.Linq;

namespace P02_RotateAndSum
{
    class P02_RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[inputArray.Length];
            for (int j = 0; j < k; j++)
            {
                ArrayShiftRight(inputArray);
                for (int i = 0; i < inputArray.Length; i++)
                {
                    sum[i] += inputArray[i];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }

        static void ArrayShiftRight(int[] array)
        {
            int mem = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = mem;            
        }
    }
}
