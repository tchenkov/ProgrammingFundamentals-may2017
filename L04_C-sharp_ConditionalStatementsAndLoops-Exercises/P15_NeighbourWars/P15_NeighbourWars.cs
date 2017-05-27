using System;

namespace P15_NeighbourWars
{
    class P15_NeighbourWars
    {
        static void Main(string[] args)
        {
            int peshosRoundhouseKickDamage = int.Parse(Console.ReadLine());
            int goshosThunderousFistDamage = int.Parse(Console.ReadLine());

            int peshosHealth = 100;
            int goshosHealth = 100;
            bool isPeshoAlive = true;
            
            int roundsCount = 0;

            while (true)
            {
                roundsCount++;

                if (roundsCount % 2 == 1)
                {// Pesho attacs
                    goshosHealth -= peshosRoundhouseKickDamage;
                    if (goshosHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
                }
                else
                {
                    peshosHealth -= goshosThunderousFistDamage;
                    if (peshosHealth <= 0)
                    {
                        isPeshoAlive = false;
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");
                }
                
                if (roundsCount % 3 == 0)
                {
                    peshosHealth += 10;
                    goshosHealth += 10;
                }
            }

            if (isPeshoAlive)
            {
                Console.WriteLine($"Pesho won in {roundsCount}th round.");
            }
            else
            {
                Console.WriteLine($"Gosho won in {roundsCount}th round.");
            }
        }
    }
}
