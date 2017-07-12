using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade => Grades.Average();
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for ( int i = 0; i < n; i++ )
            {
                students.Add(ReadStudent());
            }

            students = students.OrderBy(x => x.AverageGrade).Reverse().ToList();
            students = students.OrderBy(x => x.Name).ToList();


            foreach ( Student student in students )
            {
                if ( student.AverageGrade >= 5 )
                {
                    Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
                }
            }
        }

        static Student ReadStudent()
        {
            Student student = new Student();
            string[] input = Console.ReadLine().Split();
            student.Name = input[0];
            student.Grades = new List<double>();
            for ( int index = 1; index < input.Length; index++ )
            {
                student.Grades.Add(double.Parse(input[index]));
            }
            return student;
        }
    }
}
