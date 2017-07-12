using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TheatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string weekDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            double price =0;

            switch (weekDay)
            {
                case "Weekday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 12;
                    }
                    if (age > 18 && age <= 64)
                    {
                        price = 18;
                    }
                    if (age > 64 && age <= 122)
                    {
                        price = 12;
                    }
                    if (price <= 0)
                    {
                        Console.WriteLine("Error!");
                    }
                    else
                    {
                        Console.WriteLine("{0}$", price);
                    }
                    break;
                case "Weekend":
                    if (age >= 0 && age <= 18)
                    {
                        price = 15;
                    }
                    if (age > 18 && age <= 64)
                    {
                        price = 20;
                    }
                    if (age > 64 && age <= 122)
                    {
                        price = 15;
                    }
                    if (price <= 0)
                    {
                        Console.WriteLine("Error!");
                    }
                    else
                    {
                        Console.WriteLine("{0}$", price);
                    }
                    break;
                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 5;
                    }
                    if (age > 18 && age <= 64)
                    {
                        price = 12;
                    }
                    if (age > 64 && age <= 122)
                    {
                        price = 10;
                    }
                    if (price <= 0)
                    {
                        Console.WriteLine("Error!");
                    }
                    else
                    {
                        Console.WriteLine("{0}$", price);
                    }
                    break;
            }

        }
    }
}
