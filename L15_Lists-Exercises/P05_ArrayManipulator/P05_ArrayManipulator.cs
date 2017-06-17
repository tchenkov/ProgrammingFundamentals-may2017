using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_ArrayManipulator
{
    class P05_ArrayManipulator
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var command = Console.ReadLine();

            while (command != "print")
            {
                var commandLine = command
                    .Split(' ')
                    .ToList();
                switch (commandLine[0])
                {
                    case "add":
                    case "addMany":
                        var addIndex = int.Parse(commandLine[1]);
                        var addValue = commandLine
                            .Skip(2)
                            .Select(int.Parse)
                            .ToList();
                        AddNumsToList(numList, addIndex, addValue);
                        break;
                    case "contains":
                        var element = int.Parse(commandLine[1]);
                        Console.WriteLine(numList.IndexOf(element));
                        break;
                    case "remove":
                        var removeIndex = int.Parse(commandLine[1]);
                        numList.RemoveAt(removeIndex);
                        break;
                    case "shift":
                        var shiftLeftCount = int.Parse(commandLine[1]);
                        ListShiftLeft(numList, shiftLeftCount);
                        break;
                    case "sumPairs":
                        SumPairs(numList);
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", numList) + "]");
        }

        static void AddNumsToList(List<int> numList, int index, List<int> addValue)
        {
            var valuesCount = addValue.Count;
            addValue.Reverse();
            foreach (var num in addValue)
            {
                numList.Insert(index, num);
            }
        }

        static void ListShiftLeft<T>(List<T> numList, int shiftCount = 1)
        {
            for (int s = 0; s < shiftCount; s++)
            {
                var mem = numList[0];
                for (int i = 0; i < numList.Count - 1; i++)
                {
                    numList[i] = numList[i + 1];
                }
                numList[numList.Count - 1] = mem;
            }
        }

        static void SumPairs(List<int> numList)
        {
            var listLength = numList.Count;
            for (int i = 0; i < numList.Count - 1; i++)
            {
                numList[i] += numList[i + 1];
                numList.RemoveAt(i + 1);
            }
        }
    }
}
