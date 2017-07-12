using System;
using System.Linq;

namespace _07.SalesReport
{
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Sale[] sales = ReadSales();
            var towns = sales.Select(s => s.Town).Distinct().OrderBy(t => t);
            foreach ( string town in towns )
            {
                decimal salesByTown = sales.Where(s => s.Town == town).Select(s => s.Price * s.Quantity).Sum();
                Console.WriteLine($"{town} -> {salesByTown:F2}");
            }
        }

        static Sale ReadSale()
        {
            string[] input = Console.ReadLine().Split();
            return new Sale()
            {
                Town = input[0],
                Product = input[1],
                Price = decimal.Parse(input[2]),
                Quantity = decimal.Parse(input[3])
            };
        }

        static Sale[] ReadSales()
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];
            for ( int i = 0; i < n; i++ )
            {
                sales[i] = ReadSale();
            }
            return sales;
        }
    }
}
