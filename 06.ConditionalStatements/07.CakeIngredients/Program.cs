using System;
using System.ComponentModel;

namespace _07.CakeIngredients
{
    class Program
    {
        static void Main()
        {
            int count = 0;
            Begin:
            string input = Console.ReadLine();
            switch (input)
            {
                case "Bake!":
                   Console.Write("Preparing cake with {0} ingredients.",count);
                    break;
                default:
                    Console.WriteLine("Adding ingredient {0}.",input);
                    count += 1;
                    goto Begin;
            }
        }
    }
}