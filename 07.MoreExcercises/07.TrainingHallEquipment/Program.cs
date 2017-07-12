using System;

namespace _07.TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            double price = 0;
            int icount = 0;
            double total = 0;
            double budget = double.Parse(Console.ReadLine());
            int items  = int.Parse(Console.ReadLine());

            for (int i = 1; i <= items; i++)
            {
                name = Console.ReadLine();
                price = double.Parse(Console.ReadLine());
                icount = int.Parse(Console.ReadLine());
                int chars = name.Length;
                if (icount > 1)
                {
                    name = name.Insert(chars, "s");
                }
                Console.WriteLine($"Adding {icount} {name} to cart.");
                total += price * icount;
                budget -= price * icount;
            }
            if (budget > 0)
            {
                Console.WriteLine($"Subtotal: ${total:F2}");
                Console.WriteLine($"Money left: ${budget:F2}");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${total:F2}");
                Console.WriteLine($"Not enough. We need ${Math.Abs(budget):F2} more.");
            }
        }
    }
}