using System;
using System.Collections.Generic;
using System.Linq;

namespace P09_TeamworkProjects
{
    class P09_TeamworkProjects
    {
        static void Main(string[] args)
        {
            List<Team> teams = GetTeams();
           
            PrintTeams(teams);
        }

        static void PrintTeams(List<Team> teams)
        {
            var printTeams = teams
                .Where(mc => mc.Members.Count > 0)
                .ToList();
            foreach (var team in printTeams)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");

                var members = team.Members.OrderBy(n => n).ToList();
                foreach (var member in members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            var teamsToDisband = teams
                .Where(mc => mc.Members.Count == 0)
                .ToList();
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine(team.Name);
            }
        }

        private static List<Team> GetTeams()
        {

            List<Team> teams = CreateTeams();
            teams = AddMembers(teams);
            teams = teams
                .OrderByDescending(mc => mc.Members.Count)
                .ThenBy(mc => mc.Name)
                .ToList();
            return teams;
        }


        static List<Team> AddMembers(List<Team> teams)
        {
            var command = Console.ReadLine();

            while (command != "end of assignment")
            {
                var commandList = command.Split(new string[] { "->" }, StringSplitOptions.None);
                var userName = commandList[0];
                var teamName = commandList[1];

                var currentTeam = teams.FirstOrDefault(t => t.Name == teamName);

                if (currentTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    command = Console.ReadLine();
                    continue;
                }

                var currentCreator = teams.Any(c => c.Creator == userName);
                var currentUser = teams.Any(c => c.Members.Contains(userName));
                if (currentCreator || currentUser)
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                    command = Console.ReadLine();
                    continue;
                }

                currentTeam.Members.Add(userName);
                command = Console.ReadLine();
            }

            return teams;
        }

        static List<Team> CreateTeams()
        {
            List<Team> teams = new List<Team>();

            var teamsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < teamsCount; i++)
            {
                var commandList = Console.ReadLine().Split('-');
                var userName = commandList[0];
                var teamName = commandList[1];

                var currentTeam = teams.FirstOrDefault(n => n.Name == teamName);
                if (currentTeam != null)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                var currentCreator = teams.FirstOrDefault(n => n.Creator == userName);
                if (currentCreator != null)
                {
                    Console.WriteLine($"{userName} cannot create another team!");
                    continue;
                }

                var newTeam = new Team
                {
                    Name = teamName,
                    Creator = userName,
                    Members = new List<string>()
                };

                Console.WriteLine($"Team {teamName} has been created by {userName}!");

                teams.Add(newTeam);
            }

            return teams;
        }
    }

    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}
