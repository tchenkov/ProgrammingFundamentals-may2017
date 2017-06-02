using System;

namespace P01_CenturiesToMinutes
{
    class P01_CenturiesToMinutes
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            const double daysPerYear = 365.242;
            int days = (int)Math.Round(years * daysPerYear);
            int hours = days * 24;
            int minutes = hours * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes%n");
        }
    }
}
