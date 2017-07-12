using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            //Console.WriteLine("Please provide your age");
            int age = int.Parse(Console.ReadLine());
            // Console.WriteLine("Please enter your employee ID");
            int eId = int.Parse(Console.ReadLine());
            // Console.WriteLine("And finally your salary :) ");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}\nAge: {1}\nEmployee ID: {2:D8}\nSalary: {3:F2}", name, age, eId, salary);
        }
    }
}
