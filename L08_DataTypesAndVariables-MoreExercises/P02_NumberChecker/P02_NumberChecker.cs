using System;

namespace P02_NumberChecker
{
    class P02_NumberChecker
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();
            try
            {
                long.Parse(numberString);
                Console.WriteLine("integer");
            }
            catch (Exception)
            {
                try
                {
                    decimal.Parse(numberString);
                    Console.WriteLine("floating-point");
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
