using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_PlayCatch
{
    class P07_PlayCatch
    {
        static void Main(string[] args)
        {
            Catch3Exeptions();
        }

        static void Catch3Exeptions()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var exeptionsLeft = 3;
            while (exeptionsLeft > 0)
            {
                var command = Console.ReadLine();
                var instuction = command.Split(' ').First();
                var commandList = command.Split(' ').Skip(1).ToArray();
                
                try
                {
                    switch (instuction)
                    {
                        case "Replace":
                            RaplaceNum(nums, commandList);
                            break;
                        case "Print":
                            PrintNumRange(nums, commandList);
                            break;
                        case "Show":
                            PrintNumAt(nums, commandList);
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exeptionsLeft--;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    exeptionsLeft--;
                }
            }

            Console.WriteLine(string.Join(", ", nums));
        }

        static void PrintNumAt(int[] nums, string[] commandList)
        {
            var index = int.Parse(commandList[0]);
            Console.WriteLine(nums[index]);
        }

        static void PrintNumRange(int[] nums, string[] commandList)
        {
            var startIndex = int.Parse(commandList[0]);
            var end = int.Parse(commandList[1]);
            var result = new List<int>();
            for (int i = startIndex; i <= end; i++)
            {
                result.Add(nums[i]);
            }
            Console.WriteLine(string.Join(", ", result));
        }

        static void RaplaceNum(int[] nums, string[] commandList)
        {
            var index = int.Parse(commandList[0]);
            nums[index] = int.Parse(commandList[1]);
        }
    }
}
