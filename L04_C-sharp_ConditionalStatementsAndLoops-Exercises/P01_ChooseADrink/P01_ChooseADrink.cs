using System;

namespace P01_ChooseADrink
{
    class P01_ChooseADrink
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            string drink;
            switch (profession)
            {
                case "Athlete":
                    drink = "Water";
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    break;
                case "SoftUni Student":
                    drink = "Beer"; // I can't C#
                    break;
                default:
                    drink = "Tea";
                    break;
            }

            Console.WriteLine(drink);
        }
    }
}
