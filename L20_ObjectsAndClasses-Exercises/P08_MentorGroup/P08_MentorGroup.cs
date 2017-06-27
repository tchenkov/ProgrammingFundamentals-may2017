using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P08_MentorGroup
{
    class P08_MentorGroup
    {
        static void Main(string[] args)
        {
            var students = GetStudentsInfo();

            PrintStudentsReport(students);
        }

        static void PrintStudentsReport(Dictionary<string, Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.Key);
                Console.WriteLine("Comments:");
                foreach (var coment in student.Value.Comments)
                {
                    Console.WriteLine($"- {coment}");
                }
                Console.WriteLine("Dates attended:");
                var attendance = student.Value.AttendanceDates.OrderBy(d => d).ToList();
                foreach (var date in attendance)
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }
            }
        }

        private static Dictionary<string, Student> GetStudentsInfo()
        {
            Dictionary<string, Student> students = GetStudentsAttendanceDates();
            students = GetStudentsNameAndComments(students);
            return students
                .OrderBy(n => n.Key)
                .ToDictionary(k => k.Key, s => s.Value);
        }

        static Dictionary<string, Student> GetStudentsNameAndComments(
            Dictionary<string, Student> students)
        {
            var command = Console.ReadLine();

            while (command != "end of comments")
            {
                var commandList = command.Split('-').ToList();
                var currentName = commandList[0];
                var comment = commandList[1];
                if (students.ContainsKey(currentName))
                {
                    students[currentName].Comments.Add(comment);
                }

                command = Console.ReadLine();
            }

            return students;
        }

        static Dictionary<string, Student> GetStudentsAttendanceDates()
        {
            var students = new Dictionary<string, Student>();
            var command = Console.ReadLine();

            while (command != "end of dates")
            {
                var commandList = command.Split(' ').ToList();
                var currentName = commandList[0];

                if (!students.ContainsKey(currentName))
                {
                    students[currentName] = new Student
                    {
                        Name = currentName,
                        AttendanceDates = new List<DateTime>()
                    };
                }

                if (commandList.Count > 1)
                {
                    students[currentName].AttendanceDates.AddRange(
                        commandList[1].Split(',')
                        .Select(d => DateTime.ParseExact(
                            d, "dd/MM/yyyy", CultureInfo.InvariantCulture
                            ))
                        .ToList()
                    );
                }
            command = Console.ReadLine();
            }
            
            return students;
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<string> Comments = new List<string>();
        public List<DateTime> AttendanceDates { get; set; }
    }
}
