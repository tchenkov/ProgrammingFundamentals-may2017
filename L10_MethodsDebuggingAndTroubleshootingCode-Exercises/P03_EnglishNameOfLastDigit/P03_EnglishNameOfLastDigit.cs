using System;

namespace P03_EnglishNameOfLastDigit
{
    class P03_EnglishNameOfLastDigit
    {
        static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());
            string lastDigitInEnglish = GetLastDigitInEnglish(number);
            Console.WriteLine(lastDigitInEnglish);
        }

        static string GetLastDigitInEnglish(long number)
        {
            string numberString = number.ToString();
            int digit = int.Parse(numberString.Substring(numberString.Length - 1));
           
            string[] digitsNames = new string[] 
                {
                    "zero",
                    "one",
                    "two",
                    "tree",
                    "four",
                    "five",
                    "six",
                    "seven",
                    "eight",
                    "nine"
                };
            return digitsNames[digit];
        }
    }
}
