using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace E03_NetherRealms
{
    class E03_NetherRealms
    {
        static void Main(string[] args)
        {
            var demonicInput = Console.ReadLine();
            var demonicMatches = Regex.Matches(demonicInput, @"[^,\s]+");
            var bookOfMightyDemons = new List<Demon>();

            foreach (Match summoningSpell in demonicMatches)
            {
                var mightyDemon = new Demon
                {
                    Name = summoningSpell.Value,
                    Health = GetDemonHealth(summoningSpell.Value),
                    Damage = GetDemonDamage(summoningSpell.Value)
                };
                bookOfMightyDemons.Add(mightyDemon);
            }

            bookOfMightyDemons = bookOfMightyDemons.OrderBy(n => n.Name).ToList();

            SummoningRitual(bookOfMightyDemons);
        }

        static void SummoningRitual(List<Demon> bookOfMightyDemons)
        {
            foreach (var demon in bookOfMightyDemons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage ");
            }
        }

        static double GetDemonDamage(string demonName)
        {
            var demoincNumbers = Regex.Matches(demonName, @"(?:-)?\d+(?:\.\d+)?");
            if (demoincNumbers.Count == 0)
            {
                return 0;
            }
            var demonDamage = demoincNumbers
                .Cast<Match>()
                .Select(m => double.Parse(m.Value))
                .Sum();
            var demonicArithmeticsMatches = Regex.Matches(demonName, @"[\*\/]");
            if (demonicArithmeticsMatches.Count > 0)
            {
                var demonicArithmetics = demonicArithmeticsMatches
                .Cast<Match>()
                .Select(m => m.Value)
                .Aggregate((i, j) => i + j);
                foreach (var ch in demonicArithmetics)
                {
                    if (demonDamage == 0)
                    {
                        break;
                    }
                    demonDamage = ch == '*' ?
                        demonDamage * 2 :
                        demonDamage / 2;
                }
            }

            return demonDamage;
        }

        static int GetDemonHealth(string demonName)
        {
            var demonicMatches = Regex.Matches(demonName, @"[^0-9\+\-\*\/\.]+");
            var demonHealth = demonicMatches
                .Cast<Match>()
                .Select(m =>m.Value)
                .Aggregate((i, j) => i + j)
                .ToCharArray()
                .Select(ch => (int)ch)
                .Sum();
            return demonHealth;
        }
    }

    class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
    }
}
