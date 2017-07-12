using System;
using System.Globalization;
using System.Linq;


namespace _01.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startdate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime enddate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var hollidays = new[]
            {
                "01 01",
                "03 03",
                "01 05",
                "06 05",
                "24 05",
                "06 09",
                "22 09",
                "01 11",
                "24 12",
                "25 12",
                "26 12"
            }.Select(a => DateTime.ParseExact(a, "dd MM", CultureInfo.InvariantCulture));

            var workingDaysCounter = 0;

            for ( DateTime i = startdate; i <= enddate; i = i.AddDays(1) )
            {
                var isHollyday = hollidays.Any(d => d.Day == i.Day && d.Month == i.Month);

                var isWeekend = i.DayOfWeek == DayOfWeek.Saturday
                                || i.DayOfWeek == DayOfWeek.Sunday;


                var isworkingday = !( isWeekend || isHollyday );
                if ( isworkingday )
                {
                    workingDaysCounter++;
                }
            }
            Console.WriteLine(workingDaysCounter);
        }
    }
}