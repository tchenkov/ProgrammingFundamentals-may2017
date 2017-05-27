using System;

namespace P08_CaloriesCounter
{
    class P08_CaloriesCounter
    {
        static void Main(string[] args)
        {
            var ingredientsCount = int.Parse(Console.ReadLine());
            var sumOfCalories = 0;
            for (int i = 0; i < ingredientsCount; i++)
            {
                switch (Console.ReadLine().ToLower())
                {
                    case "cheese":
                        sumOfCalories += 500;
                        break;
                    case "tomato sauce":
                        sumOfCalories += 150;
                        break;
                    case "salami":
                        sumOfCalories += 600;
                        break;
                    case "pepper":
                        sumOfCalories += 50;
                        break;
                }

            }
            Console.WriteLine($"Total calories: {sumOfCalories}");
        }
    }
}
