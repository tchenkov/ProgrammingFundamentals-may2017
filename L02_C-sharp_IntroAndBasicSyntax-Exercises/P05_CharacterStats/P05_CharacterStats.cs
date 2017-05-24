using System;

namespace P05_CharacterStats
{
    public class P05_CharacterStats
    {
        public static void Main(string[] args)
        {
            var characterName = Console.ReadLine();
            var characterHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var characterEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            string healthBar = buildStatBar(characterHealth, maxHealth);
            string energyBar = buildStatBar(characterEnergy, maxEnergy);
            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"Health: {healthBar}");
            Console.WriteLine($"Energy: {energyBar}");
        }

        public static string buildStatBar(int statValue, int barMaxValue)
        {
            string statBar = "|" + new string('|', statValue) + new string('.', barMaxValue - statValue) + "|";
            return statBar;
        }
    }
}
