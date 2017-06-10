using System;

namespace P02_ReverseArrayOfIntegers
{
    class P02_ReverseArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            
            int[] intArray = new int[arraySize];
            for (int i = arraySize - 1; i >= 0; i--)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", intArray));
        }        
    }
}
