using System;
using System.Collections.Generic;

namespace P04_FixEmails
{
    class P04_FixEmails
    {
        static void Main(string[] args)
        {
            var addressBook = new Dictionary<string, string>();
            var name = Console.ReadLine();

            while (name != "stop")
            {
                var eMailAddress = Console.ReadLine();
                AddValidEMailToAddressBook(addressBook, name, eMailAddress);

                name = Console.ReadLine();
            }

            foreach (var item in addressBook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        static void AddValidEMailToAddressBook(Dictionary<string, string> addressBook, string name, string eMailAddress)
        {
            bool isEMailValid = !eMailAddress.EndsWith(".us") && !eMailAddress.EndsWith(".uk");

            if (isEMailValid)
            {
                if (!addressBook.ContainsKey(name))
                {
                    addressBook[name] = string.Empty;
                }
                addressBook[name] = eMailAddress;
            }
        }
    }
}
