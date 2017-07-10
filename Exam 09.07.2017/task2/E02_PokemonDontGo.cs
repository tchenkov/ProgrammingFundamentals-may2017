using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class E02_PokemonDontGo
    {
        static void Main(string[] args)
        {
            var distance = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();

            var index = int.Parse(Console.ReadLine());
            long currentElement = 0;
            long sum = 0;

            while (distance.Count != 0)
            {
                if (index < 0)
                {
                    currentElement = distance[0];
                    sum += currentElement;
                    distance[0] = distance[distance.Count - 1];
                    ManipulateElements(distance, currentElement);

                    index = int.Parse(Console.ReadLine());
                    continue;

                }

                if (index >= distance.Count)
                {
                    currentElement = distance[distance.Count - 1];
                    sum += currentElement;
                    distance[distance.Count - 1] = distance[0];
                    ManipulateElements(distance, currentElement);

                    index = int.Parse(Console.ReadLine());
                    continue;
                }

                currentElement = distance[index];
                sum += currentElement;
                distance.RemoveAt(index);

                if (distance.Count == 0)
                {
                    continue;
                }
                ManipulateElements(distance, currentElement);

                index = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }

        static void ManipulateElements(List<long> distance, long currentElement)
        {
            for (int i = 0; i < distance.Count; i++)
            {
                distance[i] =
                    distance[i] > currentElement ?
                    distance[i] - currentElement :
                    distance[i] + currentElement;
            }
        }
    }
}
