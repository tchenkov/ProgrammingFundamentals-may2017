using System;

namespace P03_BackIn30Minutes
{
    class P03_BackIn30Minutes
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            minutes += 30;
            while (minutes >= 60)
            {
                minutes -= 60;
                hours++;
            }

            while (hours >= 24)
            {
                hours -= 24;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
