using System;
using System.Collections.Generic;

namespace P02_AdvertisementMessage
{
    class P02_AdvertisementMessage
    {
        static void Main(string[] args)
        {
            var messagesCount = int.Parse(Console.ReadLine());
            var messages = GenerateRandomMessage(messagesCount);

           Console.WriteLine(string.Join(" ", messages));
        }

        static List<string> GenerateRandomMessage(int count)
        {
            var phrases = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            var events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            var author = new string[]
            {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            var city = new string[]
            {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            var rand = new Random();
            var result = new List<string>();
            for (int i = 0; i < count; i++)
            {
                var randomPhrase = phrases[rand.Next(phrases.Length)];
                var randomEvent = events[rand.Next(events.Length)];
                var randomAuthor = author[rand.Next(author.Length)];
                var randomCity = city[rand.Next(city.Length)];
                result.Add($"{randomPhrase} {randomEvent} {randomAuthor} – {randomCity}.");
            }

            return result;
        }
    }
}
