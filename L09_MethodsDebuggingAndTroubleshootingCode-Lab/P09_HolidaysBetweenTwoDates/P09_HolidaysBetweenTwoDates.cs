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
            var holidaysCount = GetWeekendsCount(startDate, endDate);
            Console.WriteLine(holidaysCount);
        }

        static int GetWeekendsCount(DateTime startDate, DateTime endDate)
        {
            startDate = startDate.AddDays(
                            (int)startDate.DayOfWeek >= 1 ?
                            6 - (int)startDate.DayOfWeek :
                            0
                            );
            var weekendsCount = 0;
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday)
                {
                    weekendsCount++;
                }
                if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    weekendsCount++;
                    date = date.AddDays(5);
                }

            }
            return weekendsCount;
        }
    }
}
