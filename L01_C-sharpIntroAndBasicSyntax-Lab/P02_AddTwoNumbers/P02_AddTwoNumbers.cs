using System;

namespace P02_AddTwoNumbers
{
    public class P02_AddTwoNumbers
    {
        public static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var sum = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {sum}");
        }
    }
}
