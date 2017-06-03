using System;

namespace P08_EmployeeData
{
    class P08_EmployeeData
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = byte.Parse(Console.ReadLine());
            var gender = char.Parse(Console.ReadLine());
            var personalID = long.Parse(Console.ReadLine());
            var employeeID = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalID}");
            Console.WriteLine($"Unique Employee number: {employeeID}");
        }
    }
}
