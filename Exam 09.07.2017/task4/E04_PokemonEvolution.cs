using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class E04_PokemonEvolution
    {
        static void Main(string[] args)
        {
            var pokeBook = new Dictionary<string, List<PokeVolution>>();
            PokePokeAddAdd(pokeBook);

            PrintPokeBook(pokeBook);

        }

        static void PrintPokeBook(Dictionary<string, List<PokeVolution>> pokeBook)
        {


            foreach (var pokemon in pokeBook)
            {
                Console.WriteLine($"# {pokemon.Key}");
                foreach (var evolution in pokemon.Value
                    .OrderByDescending(poke => poke.Index))
                {
                    Console.WriteLine($"{evolution.Type} <-> {evolution.Index}");
                }
            }
        }

        static void PokePokeAddAdd(Dictionary<string, List<PokeVolution>> pokeBook)
        {
            var command = Console.ReadLine();

            while (command != "wubbalubbadubdub")
            {
                var commandList = command
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var pokeName = commandList[0];
                if (commandList.Length != 3)
                {
                    if (pokeBook.ContainsKey(pokeName))
                    {
                        Console.WriteLine($"# {pokeName}");
                        foreach (var evo in pokeBook[pokeName])
                        {
                            Console.WriteLine($"{evo.Type} <-> {evo.Index}");
                        }
                    }
                    command = Console.ReadLine();
                    continue;
                }

                var evoType = commandList[1];
                var evoIndex = int.Parse(commandList[2]);

                if (!pokeBook.ContainsKey(pokeName))
                {
                    pokeBook[pokeName] = new List<PokeVolution>();
                }
                var currentEvo = new PokeVolution
                {
                    Type = evoType,
                    Index = evoIndex
                };

                pokeBook[pokeName].Add(currentEvo);


                command = Console.ReadLine();
            }
        }
    }

    class PokeVolution
    {
        public string Type { get; set; }
        public int Index { get; set; }
    }
}
