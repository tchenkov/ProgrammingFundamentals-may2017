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
                    AddPhoneNumber(phoneBook, commandList, name);
                }

                if (instruction == "S")
                {
                    SearchPhoneNumberByName(phoneBook, name);
                }

                command = Console.ReadLine();
            }
        }

        private static void SearchPhoneNumberByName(Dictionary<string, string> phoneBook, string name)
        {
            Console.WriteLine(
                phoneBook.ContainsKey(name) ?
                $"{name} -> {phoneBook[name]}" :
                $"Contact {name} does not exist."
                );
        }

        static void AddPhoneNumber(Dictionary<string, string> phoneBook,
            List<string> commandList, string name)
        {
            var phoneNumber = commandList[2];
            if (!phoneBook.ContainsKey(name))
            {
                phoneBook[name] = string.Empty;
            }
            phoneBook[name] = phoneNumber;
        }
    }
}
