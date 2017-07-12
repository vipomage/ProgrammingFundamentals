using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);


            DateTime[] nonWorkingDays = new DateTime[21];

            nonWorkingDays[0] = DateTime.ParseExact($"01-01-{endDate.Year.ToString()}", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            nonWorkingDays[1] = DateTime.ParseExact($"03-03-{endDate.Year.ToString()}", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            nonWorkingDays[2] = DateTime.ParseExact($"01-05-{endDate.Year.ToString()}", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            nonWorkingDays[3] = DateTime.ParseExact($"06-05-{endDate.Year.ToString()}", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            nonWorkingDays[4] = DateTime.ParseExact($"24-05-{endDate.Year.ToString()}", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            nonWorkingDays[5] = DateTime.ParseExact($"06-09-{endDate.Year.ToString()}", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            nonWorkingDays[6] = DateTime.ParseExact($"22-09-{endDate.Year.ToString()}", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            nonWorkingDays[7] = DateTime.ParseExact($"01-11-{endDate.Year.ToString()}", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            nonWorkingDays[8] = DateTime.ParseExact($"24-12-{endDate.Year.ToString()}", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            nonWorkingDays[9] = DateTime.ParseExact($"25-12-{endDate.Year.ToString()}", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            nonWorkingDays[10] = DateTime.ParseExact($"26-12-{endDate.Year.ToString()}", "dd-MM-yyyy", CultureInfo.InvariantCulture);


            int workdays = 0;
            for ( DateTime i = startDate.Date; i <= endDate.Date; i = i.AddDays(1) )
            {
                var isHoliday = nonWorkingDays.Any(d => d.Day == i.Day && d.Month == i.Month);

                var isWeekend = i.DayOfWeek == DayOfWeek.Saturday 
                    || i.DayOfWeek == DayOfWeek.Sunday;

                var isWorkingDay = !( isWeekend || isHoliday );
                if ( isWorkingDay )
                {
                    workdays += 1;
                }
            }
            Console.WriteLine(workdays);
        }
    }
}
