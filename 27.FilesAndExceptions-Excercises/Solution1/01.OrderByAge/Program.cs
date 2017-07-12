using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.OrderByAge
{
    class Student
    {
        public string Name { get; set; }

        public string Studentid { get; set; }

        public int Age { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Student> Students = new List<Student>();

            while ( true )
            {
                string[] input = Console.ReadLine().Split();
                if ( input[0].ToLower() == "end" )
                {
                    break;
                }
                Student inputStudent = new Student()
                {
                    Name = input[0],
                    Studentid = input[1],
                    Age = int.Parse(input[2])
                };
                Students.Add(inputStudent);
            }

            foreach ( Student student in Students.OrderBy(a => a.Age) )
            {
                Console.WriteLine($"{student.Name} with ID: {student.Studentid} is {student.Age} years old.");
            }
        }
    }
}
