using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_ManipulateArray
{
    class P02_ManipulateArray
    {
        static void Main(string[] args)
        {
            var wordsList = Console.ReadLine()
                .Split(' ')
                .ToList();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();
                if (command[0] == "Reverse")
                {
                    wordsList.Reverse();
                    continue;
                }
                if (command[0] == "Distinct")
                {
                    wordsList = wordsList.Distinct().ToList();
                    continue;
                }
                int index = int.Parse(command[1]);
                var replacingWord = command[2];
                wordsList[index] = replacingWord;
            }

            Console.WriteLine(string.Join(", ", wordsList));
        }
    }
}
