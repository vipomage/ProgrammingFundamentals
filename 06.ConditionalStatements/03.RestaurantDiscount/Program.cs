using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace _03.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int gSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double discount = 0;
            double price = 0;
            string type = null;
            double dPrice = 0;

            switch (package)
            {
                case "Normal":
                    discount = 0.95;
                    dPrice = 500;
                    break;
                case "Gold":
                    discount = 0.90;
                    dPrice = 750;
                    break;
                case "Platinum":
                    discount = 0.85;
                    dPrice = 1000;
                    break;
            }

            if (gSize >= 0 && gSize <= 50)
            {
                price = 2500;
                type = "Small Hall";
                Console.WriteLine(
                    $"We can offer you the {type}\nThe price per person is {((price + dPrice) * discount) / gSize:F2}$");
            }
            if (gSize > 50 && gSize <= 75)
            {
                price = 5000;
                type = "Terrace";
                Console.WriteLine(
                    $"We can offer you the {type}\nThe price per person is {((price + dPrice) * discount) / gSize:F2}$");
            }
            if (gSize > 75 && gSize <= 120)
            {
                price = 7500;
                type = "Great Hall";
                Console.WriteLine(
                    $"We can offer you the {type}\nThe price per person is {((price + dPrice) * discount) / gSize:F2}$");
            }
            if (gSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}