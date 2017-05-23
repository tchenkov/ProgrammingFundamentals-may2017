using System;

namespace P01_DebitCardNumber
{
    public class P01_DebitCardNumber
    {
        public static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:D4} {1:D4} {2:0000} {3:0000}", num1, num2, num3, num4);
        }
    }
}
