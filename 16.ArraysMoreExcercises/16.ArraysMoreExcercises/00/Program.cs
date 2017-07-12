using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            var indegrient = Console.ReadLine().Split(' ');
            int indegrientLength = int.Parse(Console.ReadLine());
            int lengthOfTheArray = 0;

            for (int index = 0; index < indegrient.Length; index++)
            {

                if (indegrient[index].Length == indegrientLength)
                {
                    lengthOfTheArray++;
                }
            }

            var recipe = new string[lengthOfTheArray];
            int countIndegriend = 0;

            for (int index = 0, indexOfRecipeArr = 0; index < indegrient.Length; index++)
            {
                if (indegrient[index].Length == indegrientLength)
                {
                    if (countIndegriend == 10)
                    {
                        break;
                    }

                    recipe[indexOfRecipeArr] = indegrient[index];
                    Console.WriteLine($"Adding {indegrient[index]}.");
                    countIndegriend++;
                    indexOfRecipeArr++;
                }
            }

            Console.WriteLine($"Made pizza with total of {countIndegriend} ingredients.\nThe ingredients are: {string.Join(", ", recipe).TrimEnd(',', ' ')}.");

        }
    }
}