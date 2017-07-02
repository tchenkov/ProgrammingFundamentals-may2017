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
            decimal result = 0;
            foreach (var item in inputArr)
            {
                var startChar = item[0];
                var num = decimal.Parse(item.Substring(1, item.Length - 2 ));
                var lastChar = item[item.Length - 1];
                num = char.IsUpper(startChar) ?
                    num / (startChar - 'A' + 1) :
                    num * (startChar - 'a' + 1);
                num = char.IsUpper(lastChar) ?
                    num - (lastChar - 'A' + 1) :
                    num + (lastChar - 'a' + 1);
                result += num;
            }

            return result;
        }        
    }
}
