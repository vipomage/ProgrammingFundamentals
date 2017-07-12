using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace _08.UpgradedMatcher
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split();
            decimal[] quantities = new decimal[products.Length];
            string empty = " 0 0 0 0 0 0 0 0 0 0";
            string inputQuantities = Console.ReadLine();
            if (inputQuantities.Split(' ').Length < products.Length)
            {
                inputQuantities += empty;
            }
            quantities = inputQuantities.Split(' ').Select(decimal.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
        INPUT:
            string[] command = Console.ReadLine().Split(' ');
            if (command[0] == "done")
            {
                return;
            }
            int ofNmeNprice = Array.IndexOf(products, $"{command[0]}");
            decimal quantity = decimal.Parse(command[1]);
            while (command[0] != "done")
            {
                if (long.Parse(command[1]) > (quantities[ofNmeNprice]))
                {
                    Console.WriteLine($"We do not have enough {command[0]}");
                }
                else
                {
                    Console.WriteLine(
                        $"{products[ofNmeNprice]} x {command[1]} costs {quantity * prices[ofNmeNprice]:F2}");
                    quantities[ofNmeNprice] = quantities[ofNmeNprice] - quantity;
                }
                goto INPUT;
            }
        }
    }

}
