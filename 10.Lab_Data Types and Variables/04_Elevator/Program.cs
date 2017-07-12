using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double courses = 0;
            if (persons % capacity != 0)
            {
                courses = (persons / capacity) + 1;
            }
            else
            {
                courses = persons/capacity;
            }
            Console.WriteLine($"{Math.Ceiling(courses)}");
        }
    }
}
