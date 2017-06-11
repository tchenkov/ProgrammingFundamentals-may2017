using System;
using System.Linq;

namespace P03_FoldAndSum
{
    class P03_FoldAndSum
    {
        static void Main(string[] args)
        {
            var arrayInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var arrayInputLastQuaterReverced = arrayInput
                .Reverse()
                .Take(arrayInput.Length / 4)
                .ToArray();
            var arrayInputFolded = arrayInput
                .Take(arrayInput.Length / 4)
                .Reverse()
                .Concat(arrayInputLastQuaterReverced)
                .ToArray();
            var arrayInputEdited = arrayInput
                .Skip(arrayInput.Length / 4)
                .Take(arrayInput.Length / 2)
                .ToArray();
            
            foreach (var item in arrayInputEdited.Zip(arrayInputFolded, Tuple.Create))
            {
                Console.Write($"{item.Item1 + item.Item2} ");
            }
        }
    }
}
