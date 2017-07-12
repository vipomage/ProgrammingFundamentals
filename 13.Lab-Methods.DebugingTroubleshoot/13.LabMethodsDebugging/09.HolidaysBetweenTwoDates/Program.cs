using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        var holidaysCount = 0;
        var startDate = DateTime.ParseExact(Console.ReadLine(),"d.M.yyyy",null);
        var endDate =   DateTime.ParseExact(Console.ReadLine(),"d.M.yyyy",null);


        for (var date = startDate; date <= endDate;)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            }
            date = date.AddHours(24);
        }
        Console.WriteLine(holidaysCount);
    }
}
