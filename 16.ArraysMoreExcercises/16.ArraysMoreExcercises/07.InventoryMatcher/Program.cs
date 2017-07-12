using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.InventoryMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products    = Console.ReadLine().Split();
            long[]   quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] prices     = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            string command = Console.ReadLine();

            while(command != "done")
            {
                int indexOf = Array.IndexOf(products, $"{command}");
                Console.WriteLine($"{products[indexOf]} costs: {prices[indexOf]}; Available quantity: {quantities[indexOf]}");
                command = Console.ReadLine();
            }

        }
    }
}
