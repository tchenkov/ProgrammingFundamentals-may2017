using System;
using System.Globalization;

namespace P09_HolidaysBetweenTwoDates
{
    class P09_HolidaysBetweenTwoDates
    {
        static void Main(string[] args)
        {
            string dateFormatString = "d.M.yyyy";
            var startDate = DateTime.ParseExact(
                Console.ReadLine(),
                dateFormatString,
                CultureInfo.InvariantCulture
                );
            var endDate = DateTime.ParseExact(
                Console.ReadLine(),
                dateFormatString,
                CultureInfo.InvariantCulture
                );
            var holidaysCount = 0;
            startDate = startDate.AddDays(
                (int)startDate.DayOfWeek >= 1 ?
                6 - (int)startDate.DayOfWeek :
                0
                );
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday)
                {
                    holidaysCount++;
                }
                if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                    date = date.AddDays(5);
                }

            }
            Console.WriteLine(holidaysCount);
        }
    }
}
