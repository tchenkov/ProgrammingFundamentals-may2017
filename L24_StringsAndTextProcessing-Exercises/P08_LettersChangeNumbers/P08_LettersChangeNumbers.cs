using System;
using System.Linq;

namespace P08_LettersChangeNumbers
{
    class P08_LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine()
                .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var result = CalcSum(inputArr);
            Console.WriteLine($"{result:f2}");
        }
                
        static decimal CalcSum(string[] inputArr)
        {
            var length = inputArr.Length;
            var result = new decimal[length];
            for (int i = 0; i < length; i++)
            {
                var startChar = inputArr[i][0];
                var num = decimal.Parse(inputArr[i].Substring(1, inputArr[i].Length - 2 ));
                var lastChar = inputArr[i][inputArr[i].Length - 1];
                num = char.IsUpper(startChar) ?
                    num / (startChar - 'A' + 1) :
                    num * (startChar - 'a' + 1);
                num = char.IsUpper(lastChar) ?
                    num - (lastChar - 'A' + 1) :
                    num + (lastChar - 'a' + 1);
                result[i] = num;
            }

            return result.Sum();
        }        
    }
}
