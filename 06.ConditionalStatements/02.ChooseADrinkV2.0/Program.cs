using System;

namespace _02.ChooseADrinkV2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string proff = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double water = 0.70;
            double Coffee = 1.00;
            double Beer = 1.70;
            double Tea = 1.20;

            switch (proff)
            {
                case "Athlete":
                    Console.WriteLine($"The {proff} has to pay {water * quantity:F2}."); break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine($"The {proff} has to pay {Coffee * quantity:F2}."); break;
                case "SoftUni Student":
                    Console.WriteLine($"The {proff} has to pay {Beer * quantity:F2}."); break;
                default:
                    Console.WriteLine($"The {proff} has to pay {Tea * quantity:F2}."); break;
            }
        }
    }
}