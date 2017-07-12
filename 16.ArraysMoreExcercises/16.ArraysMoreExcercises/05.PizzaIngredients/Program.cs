using System;
using System.Linq;

namespace _05.PizzaIngredients
{
    class Program
    {
        static void Main()
        {
            int counter = 0;
            bool equal;
            string added = String.Empty;
            string[] ingredientsArray = Console.ReadLine().Split(' ');
            int ingredientLength = int.Parse(Console.ReadLine());
            foreach (string ingredient in ingredientsArray)
            {
                equal = ingredient.Length == ingredientLength;
                if (equal)
                {
                    if (counter == 10)
                    {
                        goto skip;
                    }
                    added += $"{ingredient}" + ".";
                    Console.WriteLine($"Adding {ingredient}.");
                    counter++;
                skip:;
                }
            }
            string[] addedIngredients = added.Split('.');
            if (addedIngredients.Count() > 10)
            {
                addedIngredients[addedIngredients.Length - 1] = null;
                counter = 10;
            }
            Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            Console.Write($"The ingredients are: {string.Join(", ", addedIngredients).TrimEnd(',', ' ')}.");
        }
    }

}
