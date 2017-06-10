using System;

namespace P03_LastKNumbersSums
{
    class P03_LastKNumbersSums
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int previousKElements = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            array[0] = 1;
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 1; j <= previousKElements; j++)
                {
                    if (i - j >= 0)
                    {
                        array[i] += array[i - j];
                        continue;
                    }
                    break;           
                }
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
