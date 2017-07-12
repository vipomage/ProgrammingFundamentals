using System;
using System.Linq;

namespace _03.SafeManipulation
{

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string command = Console.ReadLine();
            while (command != "END" || command.Contains("Reverse") || command.Contains("Distinct") || command.Contains("Replace"))
            {
                if (command.Contains("Reverse"))
                {
                    Array.Reverse(input);
                    command = Console.ReadLine();
                }
                if (command.Contains("Distinct"))
                {
                    input = input.Distinct().ToArray();
                    command = Console.ReadLine();
                }
                if (command.Contains("Replace"))
                {
                    string[] replaceArr = command.Split(' ');
                    if (replaceArr[0] == "Replace")
                    {
                        try
                        {
                            int removeNumber = int.Parse(replaceArr[1]);
                            input[removeNumber] = replaceArr[2];
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        command = Console.ReadLine();
                    }
                }
                if (!command.Contains("Reverse") && !command.Contains("Distinct") && !command.Contains("Replace") && !command.Contains("END"))
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                }
            }
            if (command == "END")
            {
                Console.WriteLine(string.Join(", ", input));
            }
        }
    }

}
