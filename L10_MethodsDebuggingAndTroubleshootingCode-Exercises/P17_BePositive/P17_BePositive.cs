using System;
using System.Collections.Generic;

namespace P17_BePositive
{
    class P17_BePositive
    {
        static void Main(string[] args)
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                
                var numbersList = new List<int>();
                for (int j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        numbersList.Add(int.Parse(input[j]));
                    }
                }

                bool isFound = false;
                for (int j = 0; j < numbersList.Count; j++)
                {
                    int currentNum = numbersList[j];

                    if (currentNum >= 0)
                    {
                        Console.Write(isFound ? $" {currentNum}" : $"{currentNum}");
                        isFound = true;
                    }
                    if (currentNum < 0)
                    {
                        if (j + 1 >= numbersList.Count)
                        {
                            continue;
                        }
                        currentNum = numbersList[j] + numbersList[j + 1];
                        if (currentNum >= 0)
                        {
                            Console.Write(isFound ? $" {currentNum}" : $"{currentNum}");
                            isFound = true;                            
                        }
                        j++;
                    }
                }

                if (isFound)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("(empty)");
                }
            }
        }
    }
}
