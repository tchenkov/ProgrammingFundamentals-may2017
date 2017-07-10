using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class E01_Poke_Mon
    {
        static void Main(string[] args)
        {
            var pokePowerN = int.Parse(Console.ReadLine()); // dobuble???
            var pokeHalfPower = pokePowerN / 2.0;
            var pokeddistanceM = int.Parse(Console.ReadLine());
            var exhaustionFactorY = int.Parse(Console.ReadLine());

            var pokeCounter = 0;
            while (pokePowerN >= pokeddistanceM) // ????
            {
                pokePowerN -= pokeddistanceM;
                pokeCounter++;
                if (pokePowerN == pokeHalfPower && exhaustionFactorY !=0)
                {
                    pokePowerN /= exhaustionFactorY;
                }

            }

            Console.WriteLine(pokePowerN);
            Console.WriteLine(pokeCounter);
        }
    }
}
