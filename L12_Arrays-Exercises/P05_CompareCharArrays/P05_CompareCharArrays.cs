using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_CompareCharArrays
{
    class P05_CompareCharArrays
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            var secondInput = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            if (firstInput == secondInput)
            {
                Console.WriteLine(firstInput);
                Console.WriteLine(secondInput);
                return;
            }

            for (int i = 0; i < Math.Min(firstInput.Length, secondInput.Length); i++)
            {
                if (firstInput[i] == secondInput[i])
                {
                    continue;
                }
                if (firstInput[i] < secondInput[i])
                {
                    Console.WriteLine(firstInput);
                    Console.WriteLine(secondInput);
                    return;
                }
                else
                {
                    Console.WriteLine(secondInput);
                    Console.WriteLine(firstInput);
                    return;
                }
            }

            Console.WriteLine(
                firstInput.Length < secondInput.Length ?
                string.Join(string.Empty, firstInput) :
                string.Join(string.Empty, secondInput)
                );
            Console.WriteLine(
                firstInput.Length > secondInput.Length ?
                string.Join(string.Empty, firstInput) :
                string.Join(string.Empty, secondInput)
                );
        }
    }
}
