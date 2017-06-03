using System;

namespace P07_ExchangeVariableValues
{
    class P07_ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            bool isBefore = true;
            OutputTwoNumbers(num1, num2, isBefore);
            SwapIntValues(ref num1, ref num2, ref isBefore);
            OutputTwoNumbers(num1, num2, isBefore);
        }

        static void OutputTwoNumbers(int num1, int num2, bool isBefore)
        {
            Console.WriteLine(isBefore ? "Before:" : "After:");
            Console.WriteLine($"a = {num1}");
            Console.WriteLine($"b = {num2}");
        }

        static void SwapIntValues (ref int num1, ref int num2, ref bool isBefore)
        {
            isBefore = !isBefore;
            int memoryNum = num1;
            num1 = num2;
            num2 = memoryNum;
        }
    }
}
