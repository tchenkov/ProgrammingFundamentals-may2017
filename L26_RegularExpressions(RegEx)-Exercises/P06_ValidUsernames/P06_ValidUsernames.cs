using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P06_ValidUsernames
{
    class P06_ValidUsernames
    {
        static void Main(string[] args)
        {
            var rawUsernameText = Console.ReadLine();
            var validUsernamePattern = 
                @"(?<=^|[ \/\\\(\)])[A-Za-z][A-Za-z\d_]{2,24}(?=$|[ \/\\\(\)])";
            var usernamesArr =
                Regex.Matches(rawUsernameText, validUsernamePattern)
                .Cast<Match>()
                .Select(m => m.Value)
                .ToArray();
            var maxSum = 0;
            var index = -1;
            for (int i = 0; i < usernamesArr.Length - 1; i++)
            {
                var currentSum = 
                    usernamesArr[i].Length + usernamesArr[i + 1].Length;

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    index = i;
                }
            }

            Console.WriteLine(usernamesArr[index]);
            Console.WriteLine(usernamesArr[index + 1]);
        }
    }
}
