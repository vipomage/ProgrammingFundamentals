using System;

namespace _08.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine().ToLower());
            long pID = long.Parse(Console.ReadLine());
            int eID = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}\n" +
                              $"Last name: {lastName}\n" +
                              $"Age: {age}\n" +
                              $"Gender: {gender}\n" +
                              $"Personal ID: {pID}\n" +
                              $"Unique Employee number: {eID}");
        }
    }
}
