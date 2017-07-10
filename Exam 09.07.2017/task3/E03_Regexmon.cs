using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task3
{
    class E03_Regexmon
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            bool isItDidiTurn = true;
            bool isMatchValid = true;
            var startIndex = 0;

            while (isMatchValid)
            {
                var pattern = isItDidiTurn ?
                    @"[^A-Za-z\-]+" :
                    @"[A-Za-z]+\-[A-Za-z]+";
                var match = Regex.Match(text, pattern);
                isMatchValid = match.Success;
                if (isMatchValid)
                {
                    Console.WriteLine(match.Value);
                    isItDidiTurn = !isItDidiTurn;
                    startIndex = match.Index + match.Length;
                    text = text.Substring(startIndex);
                }
                

            }

        }
    }
}
