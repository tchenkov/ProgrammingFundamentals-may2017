﻿using System;
using System.Linq;

namespace P02_ChangeList
{
    class P02_ChangeList
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var command = Console.ReadLine();
            while (command != "Odd" && command != "Even")
            {
                var commandName = command
                    .Split(' ')
                    .ToList();
                var elementValue = int.Parse(commandName[1]);
                var position = commandName.Count > 2 ?
                    int.Parse(commandName[2]) :
                    0;
                
                switch (commandName[0])
                {
                    case "Delete":
                        numList = numList
                            .Where(n => n != elementValue)
                            .ToList();
                        break;
                    case "Insert":
                        numList.Insert(position, elementValue);
                        break;
                }
                command = Console.ReadLine();
            }

            numList = command == "Odd" ?
                numList.Where(n => n % 2 == 1).ToList() :
                numList.Where(n => n % 2 == 0).ToList();
            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
