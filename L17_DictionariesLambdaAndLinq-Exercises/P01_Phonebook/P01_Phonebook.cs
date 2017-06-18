using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Phonebook
{
    class P01_Phonebook
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var phoneBook = new Dictionary<string, string>();

            while (command != "END")
            {
                var commandList = command
                    .Split(' ')
                    .ToList();
                var instruction = commandList[0];
                var name = commandList[1];

                if (instruction == "A")
                {
                    var phoneNumber = commandList[2];
                    if (!phoneBook.ContainsKey(name))
                    {
                        phoneBook[name] = string.Empty;
                    }
                    phoneBook[name] = phoneNumber;
                }

                if (instruction == "S")
                {
                    Console.WriteLine(
                        phoneBook.ContainsKey(name) ?
                        $"{name} -> {phoneBook[name]}" :
                        $"Contact {name} does not exist."
                        );
                }

                command = Console.ReadLine();
            }
        }
    }
}
