using System;

namespace P01_DayOfWeek
{
    class P01_DayOfWeek
    {
        static void Main(string[] args)
        {
            string[] NamesOfDays = new string[] 
            {
                "Invalid Day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };
            int dayNumber = int.Parse(Console.ReadLine());
            dayNumber = 0 <= dayNumber && dayNumber <= 7 ? dayNumber : 0;
            Console.WriteLine(NamesOfDays[dayNumber]);
        }
    }
}
