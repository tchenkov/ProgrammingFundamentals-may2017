using System;

namespace P07_CakeIngredients
{
    class P07_CakeIngredients
    {
        static void Main(string[] args)
        {
            var ingredient = Console.ReadLine();
            var ingredientsCount = 0;

            while (ingredient != "Bake!")
            {
                ingredientsCount++;
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredient = Console.ReadLine();

            }

            Console.WriteLine($"Preparing cake with {ingredientsCount} ingredients.");
        }
    }
}
