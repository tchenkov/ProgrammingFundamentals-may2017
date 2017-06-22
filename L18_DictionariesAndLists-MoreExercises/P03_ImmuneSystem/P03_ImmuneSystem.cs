using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_ImmuneSystem
{
    class P03_ImmuneSystem
    {
        static void Main(string[] args)
        {
            
            var imuneSystemLog = new List<string>();
            var knownViruses = new List<string>();
            var maxHealth = int.Parse(Console.ReadLine());
            var currentHealth = maxHealth;

            var command = Console.ReadLine();

            while (command != "end")
            {
                var virusName = command;
                var virusStrenght = command.Sum(x => x);
                virusStrenght /= 3;
                var defeatTimeSeconds = virusStrenght * virusName.Length;
                defeatTimeSeconds =
                    knownViruses.Contains(virusName) ?
                    defeatTimeSeconds / 3 :
                    defeatTimeSeconds;
                currentHealth -= defeatTimeSeconds;

                if (currentHealth < 0)
                {
                    imuneSystemLog.Add($"Virus {virusName}: {virusStrenght} => {defeatTimeSeconds} seconds");
                    break;
                }

                var defeatTime = CalcDefeatTime(defeatTimeSeconds);

                knownViruses.Add(virusName);
                var result = $"Virus {virusName}: {virusStrenght} => {defeatTimeSeconds} seconds\n";
                result += $"{virusName} defeated in {defeatTime}.\n";
                result += $"Remaining health: {currentHealth}";
                imuneSystemLog.Add(result);
                currentHealth =
                    (int)(currentHealth * 1.2) > maxHealth ?
                    maxHealth :
                    (int)(currentHealth * 1.2);
                command = Console.ReadLine();
            }

            foreach (var entry in imuneSystemLog)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine(
                currentHealth < 0 ?
                "Immune System Defeated." :
                $"Final Health: {currentHealth}");
        }

        static string CalcDefeatTime(int defeatTimeSeconds)
        {
            var result = (defeatTimeSeconds / 60) + "m ";
            result += (defeatTimeSeconds % 60) + "s";
            return result;
        }
    }
}
