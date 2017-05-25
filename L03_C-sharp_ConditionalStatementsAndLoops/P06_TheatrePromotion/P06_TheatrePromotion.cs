using System;

namespace P06_TheatrePromotion
{
    class P06_TheatrePromotion
    {
        static void Main(string[] args)
        {
            var dayOfTheWeek = Console.ReadLine();
            var age = short.Parse(Console.ReadLine());

            if (age < 0 ||  122 < age)
            {
                Console.WriteLine("Error!");
                return;
            }

            if (age <= 18)
            {
                switch (dayOfTheWeek)
                {
                    case "Weekday":
                        Console.WriteLine("12$");
                        break;
                    case "Weekend":
                        Console.WriteLine("15$");
                        break;
                    case "Holiday":
                        Console.WriteLine("5$");
                        break;                   
                }
            }
            else if (age <= 64)
            {
                switch (dayOfTheWeek)
                {
                    case "Weekday":
                        Console.WriteLine("18$");
                        break;
                    case "Weekend":
                        Console.WriteLine("20$");
                        break;
                    case "Holiday":
                        Console.WriteLine("12$");
                        break;
                }
            }
            else
            {
                switch (dayOfTheWeek)
                {
                    case "Weekday":
                        Console.WriteLine("12$");
                        break;
                    case "Weekend":
                        Console.WriteLine("15$");
                        break;
                    case "Holiday":
                        Console.WriteLine("10$");
                        break;
                }
            }
        }
    }
}
