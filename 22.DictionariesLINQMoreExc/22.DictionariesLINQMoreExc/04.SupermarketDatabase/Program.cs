using System;
using System.Collections.Generic;

namespace _04.SupermarketDatabase
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> stocksQuantities = new Dictionary<string, int>();
            Dictionary<string, double> stocksPrices = new Dictionary<string, double>();
            double grandTotal = 0;
            string[] entry = Console.ReadLine().Split();
            while ( entry[0] != "stocked" )
            {
                string key = entry[0];
                double price = double.Parse(entry[1]);
                int quantity = int.Parse(entry[2]);
                stocksPrices[key] = price;
                if ( !stocksQuantities.ContainsKey(key) )
                {
                    stocksQuantities[key] = quantity;
                }
                else
                {
                    stocksQuantities[key] += quantity;
                }
                entry = Console.ReadLine().Split();
            }
            foreach ( string stocksQuantitiesKey in stocksQuantities.Keys )
            {
                Console.WriteLine(
                    $"{stocksQuantitiesKey}: ${stocksPrices[stocksQuantitiesKey]:F2} * {stocksQuantities[stocksQuantitiesKey]} = ${stocksQuantities[stocksQuantitiesKey] * stocksPrices[stocksQuantitiesKey]:F2}");
                grandTotal += stocksQuantities[stocksQuantitiesKey] * stocksPrices[stocksQuantitiesKey];
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${grandTotal:F2}");
        }
    }
}
