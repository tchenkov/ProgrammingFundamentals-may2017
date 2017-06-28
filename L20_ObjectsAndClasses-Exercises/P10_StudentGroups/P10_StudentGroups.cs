using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace P10_StudentGroups
{
    class P10_StudentGroups
    {
        static void Main(string[] args)
        {
            var towns = GetTownsAndStudents();
            MakeGroups(towns);
            PrintStudentsByGroupsByTowns(towns);
        }

        static void PrintStudentsByGroupsByTowns(List<Town> towns)
        {
            towns = towns.OrderBy(t => t.Name).ToList();
            var totalGroups = towns.Select(t => t.Teams.Count).Sum();
            Console.WriteLine($"Created {totalGroups} groups in {towns.Count} towns:");
            foreach (var town in towns)
            {
                for (int i = 0; i < town.Teams.Count; i++)
                {
                    Console.WriteLine($"{town.Name} => {string.Join(", ", town.Teams[i].Students.Select(s => s.EMail))}");
                }
            }
        }

        static void MakeGroups(List<Town> towns)
        {
            foreach (var town in towns)
            {
                var sortedStudents = town.Bitizens
                    .OrderBy(s => s.DateOfRegistration)
                    .ThenBy(s => s.Name)
                    .ThenBy(s => s.EMail)
                    .ToList();
                var studentsCount = sortedStudents.Count();
                var groupsCount = (int)(Math.Ceiling((double)studentsCount / town.HallCapacity));
                for (int i = 0; i < groupsCount; i++)
                {
                    var currentTeam = new List<Student>();
                    var skip = i * town.HallCapacity;
                    var take = skip + town.HallCapacity > studentsCount ?
                        studentsCount :
                        skip + town.HallCapacity;
                    for (int j = skip; j < take; j++)
                    {
                        currentTeam.Add(sortedStudents[j]);
                    }
                    var newTeam = new Team
                    {
                        Students = currentTeam
                    };
                    town.Teams.Add(newTeam);
                }

            }
        }

        static List<Town> GetTownsAndStudents()
        {
            List<Town> towns = new List<Town>();

            var commnad = Console.ReadLine();
            while (commnad != "End")
            {
                if (commnad.Contains(" => "))
                {
                    GetTown(towns, commnad);
                }
                else if (commnad != "End")
                {
                    GetStudents(towns, commnad);
                }

                commnad = Console.ReadLine();
            }

            return towns;
        }

        static void GetStudents(List<Town> towns, string command)
        {
            var studentInfo = command.Split('|');
            var newStudent = new Student
            {
                Name = studentInfo[0].Trim(),
                EMail = studentInfo[1].Replace(" ", string.Empty),
                DateOfRegistration = GetDate(studentInfo[2].Replace(" ", string.Empty))
            };
            var currentTown = towns.Last();
            currentTown.Bitizens.Add(newStudent);
        }

        static DateTime GetDate(string dateString)
        {
            var dateList = dateString.Split('-');
            for (int i = 1; i <= 12; i++)
            {
                var dtf = new DateTimeFormatInfo();
                var monthStr = dtf.GetMonthName(i).ToString();
                if (monthStr.Contains(dateList[1]))
                {
                    dateList[1] = i.ToString();
                    break;
                }
            }

            var newDate = DateTime.ParseExact(string.Join("-", dateList), "d-M-yyyy", CultureInfo.InvariantCulture);
            return newDate;
        }

        static void GetTown(List<Town> towns, string command)
        {
            var townAndHallCapacity = command.Split(new string[] { " => " }, StringSplitOptions.None);
            var newTown = new Town
            {
                Name = townAndHallCapacity[0],
                HallCapacity = int.Parse(townAndHallCapacity[1].Split(' ').First()),
                Teams = new List<Team>(),
                Bitizens = new List<Student>()
            };

            towns.Add(newTown);
        }
    }

    class Town
    {
        public string Name { get; set; }
        public int HallCapacity { get; set; }
        public List<Team> Teams { get; set; }
        public List<Student> Bitizens { get; set; }
    }

    class Team
    {
        public List<Student> Students { get; set; }
    }

    class Student
    {
        public string Name { get; set; }
        public string EMail { get; set; }
        public DateTime DateOfRegistration { get; set; }
    }
}
