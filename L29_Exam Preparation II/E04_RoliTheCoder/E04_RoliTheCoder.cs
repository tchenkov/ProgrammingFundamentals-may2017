using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace E04_RoliTheCoder
{
    class E04_RoliTheCoder
    {
        static void Main(string[] args)
        {
            var events = GetEventsAndParticipants();

            PrintEventsAndParticipants(events);
        }

        static void PrintEventsAndParticipants(Dictionary<string, Event> events)
        {
            events = events
                .OrderByDescending(pc => pc.Value.Participants.Count)
                .ThenBy(en => en.Value.Name)
                .ToDictionary(k => k.Key, v => v.Value);
            foreach (var evnt in events)
            {
                Console.WriteLine($"{evnt.Value.Name} - {evnt.Value.Participants.Count}");
                foreach (var person in evnt.Value.Participants.OrderBy(n => n))
                {
                    Console.WriteLine(person);
                }
            }
        }

        static Dictionary<string, Event> GetEventsAndParticipants()
        {
            var events = new Dictionary<string, Event>();
            var command = Console.ReadLine();

            while (command != "Time for Code")
            {
                var commandList = command
                    .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                var eventId = commandList[0];
                var eventName = commandList[1];
                if (!eventName.StartsWith("#"))
                {
                    command = Console.ReadLine();
                    continue;
                }

                eventName = eventName.Substring(1);
                if (!events.ContainsKey(eventId))
                {
                    events[eventId] = new Event
                    {
                        Id = eventId,
                        Name = eventName,
                        Participants = new List<string>()
                    };
                }
                else if (events[eventId].Name != eventName)
                {
                    command = Console.ReadLine();
                    continue;
                }
                var participantsMatches = Regex.Matches(command, @"@[A-Za-z\d'\-]+");
                if (participantsMatches.Count > 0)
                {
                    foreach (Match currentName in participantsMatches)
                    {
                        if (!events[eventId].Participants.Contains(currentName.Value))
                        {
                            events[eventId].Participants.Add(currentName.Value);
                        }
                    }
                }

                command = Console.ReadLine();
            }

            return events;
        }
    }

    class Event
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<string> Participants { get; set; }
    }
}
