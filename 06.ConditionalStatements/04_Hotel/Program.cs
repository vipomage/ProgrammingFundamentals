using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice  = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    doublePrice = 65;
                    suitePrice = 75;
                    if (nights > 7)
                    {
                        studioPrice = studioPrice * 0.95;
                    }
                    break;

                case "June":
                case "September":
                    studioPrice = 60;
                    doublePrice = 72;
                    suitePrice = 82;
                    if (nights > 14)
                    {
                        doublePrice = doublePrice * 0.90;
                    }
                    break;

                case "July":
                case "August":
                case "December":
                    studioPrice = 68;
                    doublePrice = 77;
                    suitePrice = 89;
                    if (nights > 14)
                    {
                        suitePrice = suitePrice * 0.85;
                    }
                    break;
            }
            if (nights > 7 && (month == "September" || month == "October"))
            {
                if (month == "September")
                {
                    Console.WriteLine($"Studio: {(studioPrice * nights) - studioPrice:F2} lv." +
                                      $"\nDouble: {doublePrice * nights:F2} lv." +
                                      $"\nSuite: {suitePrice * nights:F2} lv.");
                }
                if (month == "October")
                {
                    Console.WriteLine($"Studio: {(studioPrice * nights) - studioPrice:F2} lv." +
                                      $"\nDouble: {doublePrice * nights:F2} lv." +
                                      $"\nSuite: {suitePrice * nights:F2} lv.");
                }
            }
            else
            {
                Console.WriteLine($"Studio: {studioPrice * nights:F2} lv." +
                                  $"\nDouble: {doublePrice * nights:F2} lv." +
                                  $"\nSuite: {suitePrice * nights:F2} lv.");
            }
        }
    }
}