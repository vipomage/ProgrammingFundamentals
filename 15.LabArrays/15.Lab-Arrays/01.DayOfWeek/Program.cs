using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01.DayOfWeek
{

    class Program
    {
        static void Main( )
        {
            string[] dayOfweek = new[]
                {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            int input = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(dayOfweek[input - 1]);
            } catch (Exception)
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }

}