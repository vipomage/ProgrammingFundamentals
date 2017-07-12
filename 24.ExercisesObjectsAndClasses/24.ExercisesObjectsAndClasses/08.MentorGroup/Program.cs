using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08.MentorGroup
{
    class Student
    {
        public List<DateTime> Attendance = new List<DateTime>();

        public List<string> Comments { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            string[] input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            //DatesInput

            while ( input[0]!="end"&&input[1]!="of")
            {
                List<DateTime> dates = new List<DateTime>();
                for ( int i = 1; i < input.Length; i++ )
                {
                    dates.Add(DateTime.ParseExact(input[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }
                dates.Sort();
                students[input[0]] = new Student() { Attendance = dates, Comments = new List<string>() };
                input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            input = Console.ReadLine().Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            while ( input[0] != "end of comments")
            {
                if ( students.ContainsKey(input[0]) )
                {
                    students[input[0]].Comments.Add(input[1]);

                    input = Console.ReadLine().Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    
                }
                else
                {
                    input = Console.ReadLine().Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                  
                }
            }
            foreach ( KeyValuePair<string, Student> student in students.OrderBy(x => x.Key) )
            {
                Console.WriteLine($"{student.Key}");
                Console.WriteLine("Comments:");
                foreach ( string comment in student.Value.Comments )
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach ( var date in student.Value.Attendance )
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }
            }
        }
    }
}