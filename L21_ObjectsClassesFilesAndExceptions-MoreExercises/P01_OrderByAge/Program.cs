using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_OrderByAge
{
    class P01_OrderByAge
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            var command = Console.ReadLine();

            while (command != "End")
            {
                var personInfo = command.Split(' ');
                var personName = personInfo[0];
                var personId = personInfo[1];
                var personAge = int.Parse(personInfo[2]);

                var newPerson = new Person
                {
                    Name = personName,
                    IdTag = personId,
                    Age = personAge
                };
                people.Add(newPerson);

                command = Console.ReadLine();
            }

            people = people.OrderBy(p => p.Age).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} with ID: {person.IdTag} is {person.Age} years old.");
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string IdTag { get; set; }
        public int Age { get; set; }
    }
}
