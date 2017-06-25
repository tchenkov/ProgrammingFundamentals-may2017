using System;
using System.Globalization;

namespace P01_CountWorkingDays
{
    class P01_CountWorkingDays
    {
        static void Main(string[] args)
        {
            DateTime startDate = GetStartEndDate();
            DateTime endDate = GetStartEndDate();

            int workingDaysCount = GetWorkingDays(startDate, endDate);

            Console.WriteLine(workingDaysCount);
        }

        static int GetWorkingDays(DateTime start, DateTime end)
        {
            var workingDaysCount = 0;
            for (var currentDate = start; currentDate <= end; currentDate = currentDate.AddDays(1))
            {
                if (currentDate.DayOfWeek == DayOfWeek.Saturday)
                {
                    currentDate.AddDays(1);
                    continue;
                }
                if (currentDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    continue;
                }
                if (IsHoliday(currentDate))
                {
                    continue;
                }
                if (currentDate.DayOfWeek == DayOfWeek.Friday)
                {
                    currentDate.AddDays(2);                    
                }
                workingDaysCount++;
            }

            return workingDaysCount;
        }

        private static bool IsHoliday(DateTime currentDate)
        {
            DateTime[] holidays = new DateTime[]
            {
                new DateTime(2000, 1, 1),
                new DateTime(2000, 3, 3),
                new DateTime(2000, 5, 1),
                new DateTime(2000, 5, 6),
                new DateTime(2000, 5, 24),
                new DateTime(2000, 9, 6),
                new DateTime(2000, 9, 22),
                new DateTime(2000, 11, 1),
                new DateTime(2000, 12, 24),
                new DateTime(2000, 12, 25),
                new DateTime(2000, 12, 26),
            };

            foreach (var holiday in holidays)
            {
                if (currentDate.Day == holiday.Day && currentDate.Month == holiday.Month)
                {
                    return true;
                }
            }
            return false;
        }

        static DateTime GetStartEndDate()
        {
            var inputDateString = Console.ReadLine();
            var dateFormat = "d-M-yyyy";
            return DateTime.ParseExact(inputDateString, dateFormat, CultureInfo.InvariantCulture);
        }
    }
}
