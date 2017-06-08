using System;

namespace P02_MaxMethod
{
    class P02_MaxMethod
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var number3 = int.Parse(Console.ReadLine());
            var maxNumber = GetMaxNumber(number1, number2, number3);
            Console.WriteLine(maxNumber);
        }

        private static int GetMaxNumber(params int[] numbers)
        {
            int maxNumber = int.MinValue;
            foreach (var num in numbers)
            {
                maxNumber = num > maxNumber ? num : maxNumber;
            }
            return maxNumber;
        }
    }
}
