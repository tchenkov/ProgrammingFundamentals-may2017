using System;
using System.Linq;

namespace E02_Ladybugs
{
    class E02_Ladybugs
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var field = new int[fieldSize];
            var ladyBugsPisitions = Console.ReadLine()
                .Split(new char[] { })
                .Select(int.Parse)
                .ToArray();
            field = SetBugsPositions(field, ladyBugsPisitions);

            var command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                var commandList = command
                    .Split();
                var cuurentBugIndex = int.Parse(commandList[0]);
                var direction = commandList[1].ToLower();
                var flyLength = int.Parse(commandList[2]);


                var flyToIndex = direction == "right" ?
                    cuurentBugIndex + flyLength :
                    cuurentBugIndex - flyLength;
                if (!(0 <= cuurentBugIndex && cuurentBugIndex < fieldSize))
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (!(0 <= flyToIndex && flyToIndex < fieldSize))
                {
                    field[cuurentBugIndex] = 0;
                    command = Console.ReadLine();
                    continue;
                }


                if (field[cuurentBugIndex] == 0)
                {
                    command = Console.ReadLine();
                    continue;
                }
                
                if (direction == "right")
                {
                    field[cuurentBugIndex] = 0;
                    
                    var landed = false;
                    while (!landed)
                    {
                        if (field[flyToIndex] == 1)
                        {
                            flyToIndex += flyLength;
                            if (flyToIndex >= fieldSize)
                            {
                                break;
                            }
                        }
                        else
                        {
                            field[flyToIndex] = 1;
                            landed = true;
                        }
                    }
                }
                else
                {
                    field[cuurentBugIndex] = 0;
                    
                    var landed = false;
                    while (!landed)
                    {
                        if (field[flyToIndex] == 1)
                        {
                            flyToIndex -= flyLength;
                            if (flyToIndex < 0)
                            {
                                break;
                            }
                        }
                        else
                        {
                            field[flyToIndex] = 1;
                            landed = true;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }

        static int[] SetBugsPositions(int[] field, int[] ladyBugsPisitions)
        {
            for (int i = 0; i < field.Length; i++)
            {
                field[i] =
                    ladyBugsPisitions.Contains(i) ?
                    1 :
                    0;
            }
            return field;
        }
    }
}
