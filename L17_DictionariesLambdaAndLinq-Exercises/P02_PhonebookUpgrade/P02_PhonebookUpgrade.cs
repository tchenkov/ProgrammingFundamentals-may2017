using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_PhonebookUpgrade // Update, It's a software afterall :)
{
    class P02_PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var phoneBook = new SortedDictionary<string, string>();

            while (command != "END")
            {
                var commandList = command
                    .Split(' ')
                    .ToList();
                var instruction = commandList[0];
                var name = commandList.Count() > 1 ?
                    commandList[1] :
                    string.Empty;

                if (instruction == "A")
                {
                    var phoneNumber = commandList[2];
                    AddToPhoneBook(phoneBook, name, phoneNumber);
                }

                if (instruction == "S")
                {
                    PrintPhoneBookEntryOrMessage(phoneBook, name);
                }

                if (instruction == "ListAll")
                {
                    PrintPhoneBookEntryOrMessage(phoneBook);
                }

                command = Console.ReadLine();
            }
        }

        static void PrintPhoneBookEntryOrMessage(SortedDictionary<string, string> phoneBook)
        {
            foreach (var item in phoneBook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        private static void PrintPhoneBookEntryOrMessage(SortedDictionary<string, string> phoneBook, string name)
        {
            Console.WriteLine(
                phoneBook.ContainsKey(name) ?
                $"{name} -> {phoneBook[name]}" :
                $"Contact {name} does not exist."
                );
        }

        static void AddToPhoneBook(SortedDictionary<string, string> phoneBook, string name, string phoneNumber)
        {
            if (!phoneBook.ContainsKey(name))
            {
                phoneBook[name] = string.Empty;
            }
            phoneBook[name] = phoneNumber;
        }
    }
}
