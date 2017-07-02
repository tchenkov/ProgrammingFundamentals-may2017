using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_MultiplyBigNumber
{
    class P07_MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            var bigNumDigitsList = Console.ReadLine().TrimStart('0')
                .ToCharArray()
                .Select( ch => byte.Parse(ch.ToString()))
                .ToList();
            bigNumDigitsList.Reverse();
            var multiplier = byte.Parse(Console.ReadLine());

            string result = MultiplyNum(bigNumDigitsList, multiplier);

            Console.WriteLine(result);
        }

        static string MultiplyNum(List<byte> bigNumDigitsList, byte multiplier)
        {
            if (multiplier == 0)
            {
                return "0";
            }
            var result = new List<string>();
            byte add = 0;
            foreach (var digit in bigNumDigitsList)
            {
                var subResult = (byte) (digit * multiplier + add);
                var remainder = (byte) (subResult % 10);
                add = (byte) (subResult / 10);

                result.Add(remainder.ToString());
            }
            if (add > 0)
            {
                result.Add(add.ToString());
            }

            result.Reverse();
            return string.Join("", result);
        }
    }
}
