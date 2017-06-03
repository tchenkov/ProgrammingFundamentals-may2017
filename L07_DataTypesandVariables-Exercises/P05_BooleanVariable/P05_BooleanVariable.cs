using System;

namespace P05_BooleanVariable
{
    class P05_BooleanVariable
    {
        static void Main(string[] args)
        {
            bool isTrue = Convert.ToBoolean(Console.ReadLine());
            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
