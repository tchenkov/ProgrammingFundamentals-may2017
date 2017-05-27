using System;

namespace P09_CountTheIntegers
{
    class P09_CountTheIntegers
    {
        static void Main(string[] args)
        {
            int numCount = 0;
            while (true)
            {
                try
                {
                    int.Parse(Console.ReadLine());
                    numCount++;

                }
                catch (OverflowException)
                {
                    break;
                }
                catch (FormatException)
                {
                    break;
                }
            }

            Console.WriteLine(numCount);
        }
    }
}
