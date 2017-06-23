using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_ParkingValidation
{
    class P05_ParkingValidation
    {
        static void Main(string[] args)
        {
            var registredUsersAndPlates = new Dictionary<string, string>();

            var entrtiesCount = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < entrtiesCount; i++)
            {
                var commnadList = Console.ReadLine().Split(' ').ToList();
                var instruction = commnadList[0];
                if (instruction == "register")
                {
                    var user = commnadList[1];
                    var plate = commnadList[2];

                    if (IsPlateInvalid(plate))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {plate}"); // ok
                        continue;
                    }
                    if (registredUsersAndPlates.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {registredUsersAndPlates[user]}"); // ok
                        continue;
                    }
                    if (registredUsersAndPlates.ContainsValue(plate) &&
                        registredUsersAndPlates.FirstOrDefault(x => x.Value == plate).Key != user)
                    {
                        Console.WriteLine($"ERROR: license plate {plate} is busy"); // ok
                        continue;
                    }
                    if (!registredUsersAndPlates.ContainsKey(user))
                    {
                        registredUsersAndPlates[user] = plate;
                        Console.WriteLine($"{user} registered {plate} successfully"); // ok
                    }
                }

                if (instruction == "unregister")
                {
                    var user = commnadList[1];
                    if (!registredUsersAndPlates.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");                        
                    }
                    else
                    {
                        registredUsersAndPlates.Remove(user);
                        Console.WriteLine($"user {user} unregistered successfully");
                    }
                }
            }

            foreach (var user in registredUsersAndPlates)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        static bool IsPlateInvalid(string plate)
        {
            if (plate.Length != 8)
            {
                return true;
            }
            var firstLastTwoSymbols = plate.Substring(0, 2) + plate.Substring(6);
            foreach (var symbol in firstLastTwoSymbols)
            {
                if (symbol < 'A' || 'Z' < symbol)
                {
                    return true;
                }
            }
            var midleSymbols = plate.Substring(2, 4);
            foreach (var symbol in midleSymbols)
            {
                if (symbol < '0' || '9' < symbol)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
