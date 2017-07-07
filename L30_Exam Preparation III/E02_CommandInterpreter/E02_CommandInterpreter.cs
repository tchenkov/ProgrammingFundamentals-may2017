using System;
using System.Collections.Generic;
using System.Linq;
// 1:12:00
namespace E02_CommandInterpreter
{
    class E02_CommandInterpreter
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine()
                .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var size = inputList.Count;

            var command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                var commandList = command.Split();

                if (commandList[0] == "reverse")
                {
                    var index = int.Parse(commandList[2]);
                    var count = int.Parse(commandList[4]);
                    var isDataValid =  ValidateParameters(count, index, size);
                    if (!isDataValid || index + count > size)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }

                    inputList = ReverseSubList(inputList, index, count);
                }
                if (commandList[0] == "sort")
                {
                    var index = int.Parse(commandList[2]);
                    var count = int.Parse(commandList[4]);
                    var isDataValid = ValidateParameters(count, index, size);
                    if (!isDataValid || index + count > size)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }

                    inputList = SortSubList(inputList, index, count);
                }
                if (commandList[0] == "rollLeft")
                {
                    var count = int.Parse(commandList[1]);
                    var isDataValid = ValidateParameters(count);
                    if (!isDataValid)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }

                    ListShiftLeft(inputList, count);
                }
                if (commandList[0] == "rollRight")
                {
                    var count = int.Parse(commandList[1]);
                    var isDataValid = ValidateParameters(count);
                    if (!isDataValid)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }


                    ListShiftRight(inputList, count);
                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", inputList)}]");
        }

        static void ListShiftLeft(List<string> inputList, int shiftCount)
        {
            shiftCount = shiftCount % inputList.Count;
            for (int s = 0; s < shiftCount; s++)
            {
                var mem = inputList[0];
                for (int i = 0; i < inputList.Count - 1; i++)
                {
                    inputList[i] = inputList[i + 1];
                }
                inputList[inputList.Count - 1] = mem;
            }
        }

        static void ListShiftRight(List<string> inputList, int shiftCount)//// fix direction
        {
            shiftCount = shiftCount % inputList.Count;
            for (int s = 0; s < shiftCount; s++)
            {
                var mem = inputList[inputList.Count - 1];
                for (int i = inputList.Count - 1; i > 0; i--)
                {
                    inputList[i] = inputList[i - 1];
                }
                inputList[0] = mem;
            }
        }

        static List<string> SortSubList(List<string> inputList, int index, int count)
        {
            if (count == 0)
            {
                return inputList;
            }
            var result = inputList.Take(index).ToList();
            var subList = inputList.Skip(index).Take(count).OrderBy(s => s).ToList();
            var listEnd = inputList.Skip(index + count).ToList();
            result.AddRange(subList);
            result.AddRange(listEnd);
            return result;
        }

        static List<string> ReverseSubList(List<string> inputList, int index, int count)
        {
            if (count == 0)
            {
                return inputList;
            }
            var result = inputList.Take(index).ToList();
            var subList = inputList.Skip(index).Take(count).Reverse().ToList();
            var listEnd = inputList.Skip(index + count).ToList();
            result.AddRange(subList);
            result.AddRange(listEnd);
            return result;
        }

        static bool ValidateParameters(int count, int index = 0, int size = 1)
            => count >= 0 &&
                index >= 0 &&
                index < size;
    }
}
