using System;
using System.Linq;

namespace P02_EmailMe
{
    class P02_EmailMe
    {
        static void Main(string[] args)
        {
            var eMail = Console.ReadLine();
            var usernameSum = eMail.Split('@')
                .First()
                .ToCharArray()
                .Select(ch => (int) ch)
                .Sum();
            var domainSum = eMail
                .Split('@')
                .Last()
                .ToCharArray()
                .Select(ch => (int)ch)
                .Sum();
            Console.WriteLine(
                usernameSum - domainSum < 0 ?
                "She is not the one." :
                "Call her!"
            );
        }
    }
}
