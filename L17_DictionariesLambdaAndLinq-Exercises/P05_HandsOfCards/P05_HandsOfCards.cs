using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_HandsOfCards
{
    class P05_HandsOfCards
    {
        static void Main(string[] args)
        {
            var handsOfCards = new Dictionary<string, List<string>>();

            GetAllHands(handsOfCards);

            var handsValue = new Dictionary<string, int>();
            CalcHandsValues(handsOfCards, handsValue);

            PrintHandsValues(handsValue);
        }

        static void PrintHandsValues(Dictionary<string, int> handsValue)
        {
            foreach (var item in handsValue)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        static void GetAllHands(Dictionary<string, List<string>> handsOfCards)
        {
            var command = Console.ReadLine();

            while (command != "JOKER")
            {
                var name = command
                    .Split(':')
                    .First();
                command = command.Remove(0, command.IndexOf(':') + 1);
                var cards = command
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (!handsOfCards.ContainsKey(name))
                {
                    handsOfCards[name] = new List<string>();
                }
                handsOfCards[name] = handsOfCards[name].Concat(cards).ToList();
                handsOfCards[name] = handsOfCards[name].Distinct().ToList();
                command = Console.ReadLine();
            }
        }

        static void CalcHandsValues(Dictionary<string, List<string>> handsOfCards, Dictionary<string, int> handsValue)
        {
            foreach (var item in handsOfCards)
            {
                if (!handsValue.ContainsKey(item.Key))
                {
                    handsValue[item.Key] = 0;
                }
                handsValue[item.Key] += GetHandValue(item.Value);
            }
        }

        static int GetHandValue(List<string> valuesList)
        {
            var sum = 0;
            foreach (var item in valuesList)
            {
                sum += GetCardValue(item);
            }
            return sum;
        }

        static int GetCardValue(string card)
        {
            var cardValues = new Dictionary<char, int>
            {
                {'C', 1}, {'D', 2}, {'H', 3}, {'S', 4},

                {'2', 2}, {'3', 3}, {'4', 4}, {'5', 5},
                {'6', 6}, {'7', 7}, {'8', 8}, {'9', 9},
                {'1', 10}, {'J', 11}, {'Q', 12}, {'K', 13},
                {'A', 14},
            };

            var value = cardValues[card[0]];
            var multiplier = cardValues[card[card.Length - 1]];
            var result = value * multiplier;

            return result;
        }
    }
}
