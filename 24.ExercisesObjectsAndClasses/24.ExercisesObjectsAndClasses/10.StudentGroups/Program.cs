using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _10.StudentGroups
{
    class Student
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public string Name { get; set; }

        public int SeatCounts { get; set; }

        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }

        public List<Student> Students { get; set; }
    }


    class Program
    {
        static void Main()
        {
            List<Town> towns = new List<Town>();
            string input = Console.ReadLine();
            while ( input.ToLower() != "end" )
            {
                string[] inputArray;

                if ( input.Contains("=>") )
                {
                    inputArray = input.Split(new[] { '=', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if ( inputArray.Length > 3 )
                    {
                        Town town = new Town()
                        {
                            Name = inputArray[0] + " " + inputArray[1],
                            SeatCounts = int.Parse(inputArray[2]),
                            Students = new List<Student>()
                        };
                        towns.Add(town);
                    }
                    else
                    {
                        Town town = new Town()
                        {
                            Name = inputArray[0],
                            SeatCounts = int.Parse(inputArray[1]),
                            Students = new List<Student>()
                        };
                        towns.Add(town);
                    }
                }
                else
                {
                    inputArray = input.Split(new[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    Student student = new Student()
                    {
                        Name = inputArray[0] + " " + inputArray[1],
                        Email = inputArray[2],
                        RegistrationDate =
                            DateTime.ParseExact(inputArray[3], "d-MMM-yyyy", CultureInfo.InvariantCulture)
                    };
                    towns.Last().Students.Add(student);
                }
                input = Console.ReadLine();
            }

            List<Group> outGroups = DistributeStudentsIntoGroups(towns);
            Console.WriteLine(
                $"Created {outGroups.Count} groups in {towns.Count} towns:");
            foreach ( var gGroup in outGroups )
            {
                Console.WriteLine($"{gGroup.Town.Name} => {string.Join(", ", gGroup.Students.Select(e => e.Email))}");
            }
        }

        static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            var groups = new List<Group>();

            foreach ( Town town in towns.OrderBy(n => n.Name) )
            {
                IEnumerable<Student> students = town.Students.OrderBy(s => s.RegistrationDate).ThenBy(s => s.Name).ThenBy(s => s.Email);
                while ( students.Any() )
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatCounts).ToList();
                    students = students.Skip(group.Town.SeatCounts);
                    groups.Add(group);
                }
            }
            return groups;
        }
    }
}
