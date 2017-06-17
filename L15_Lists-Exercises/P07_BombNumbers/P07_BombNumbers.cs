using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_BombNumbers
{
    class P07_BombNumbers
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var bombAndPower = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            BombNumList(numList, bombAndPower[0], bombAndPower[1]);
            
            Console.WriteLine(numList.Sum());
        }

        static void BombNumList(List<int> numList, int bomb, int power)
        {
            while (numList.Contains(bomb))
            {
                var currentBombIndex = numList.IndexOf(bomb);
                var startIndex = currentBombIndex - power < 0 ?
                    0 :
                    currentBombIndex - power;
                var endIndex = currentBombIndex + power >= numList.Count ?
                    numList.Count - 1 :
                    currentBombIndex + power;
                var numberOfElementsToRemove = endIndex - startIndex;

                for (int i = 0; i <= numberOfElementsToRemove; i++)
                {
                    numList.RemoveAt(startIndex);
                }
            }
        }
    }
}
