using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_SumBigNumbers
{
    class P06_SumBigNumbers
    {
        static void Main(string[] args)
        {
            var num1List = GetStringToIntList();
            var num2List = GetStringToIntList();

            string sum = SumBigNumbers(num1List, num2List);
            Console.WriteLine(sum);
        }

        static string SumBigNumbers(List<ulong> num1List, List<ulong> num2List)
        {
            var resultStr = new List<string>();

            var shorterList = num1List.Count < num2List.Count ?
                num1List :
                num2List;
            var longerList = num1List.Count < num2List.Count ?
                num2List :
                num1List;
            var shortLength = shorterList.Count;
            ulong add = 0;
            ulong step = (ulong)Math.Pow(1000, 6);
            for (int i = 0; i < shortLength; i++)
            {
                var remainder = (shorterList[i] + longerList[i] + add) % step;
                add = (shorterList[i] + longerList[i] + add) / step;
                resultStr.Add($"{remainder:D18}");
            }
            var lengthDiff = longerList.Count - shortLength;
            if (lengthDiff > 0)
            {
                for (int i = shortLength; i < longerList.Count; i++)
                {
                    var remainder = (longerList[i] + add) % step;
                    add = 0;
                    resultStr.Add($"{remainder:D18}");
                }
            }
            resultStr.Reverse();
            resultStr[0] = resultStr[0].TrimStart('0');

            return string.Join("", resultStr);
        }

        static List<ulong> GetStringToIntList()
        {
            var numString = Console.ReadLine().TrimStart('0');
            var numLength = numString.Length;
            var take = 18;
            var iterrations = (int)Math.Ceiling(numLength / (double)take);
            var numList = new List<ulong>();
            for (int i = 0; i < iterrations; i++)
            {
                var skip = numLength > take ?
                    numLength - take :
                    0;
                take = take <= numLength ?
                    take :
                    numLength;
                var subNum = new string(numString.Skip(skip).Take(take).ToArray());
                numList.Add(ulong.Parse(subNum));

                numLength -= take;
            }
            //numList.Reverse();

            return numList;
        }
    }
}
