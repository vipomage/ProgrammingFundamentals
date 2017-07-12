using System;

namespace _01_CenturiesToMinutes
{
    class Program
    {
        static void Main()
        {
            double input = int.Parse(Console.ReadLine());

            double years   = input * 100;
            int days    = (int)(years * 365.2422);
            double hours   = days * 24;
            double minutes = 60*hours;         

            Console.WriteLine($"{input} centurise = {years} years = {days:F0} days = {hours} hours = {minutes:F0} minutes");
        }
    }
}