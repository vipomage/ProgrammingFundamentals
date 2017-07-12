using System;
using System.Linq;


namespace _02.ManipulateArray
{

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string[] commands = new string[int.Parse(Console.ReadLine())];
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i] = Console.ReadLine();
                if (commands[i].Contains("Reverse"))
                {
                    Array.Reverse(input);
                }
                if (commands[i].Contains("Distinct"))
                {
                    foreach (string s in input)
                    {
                        input = input.Distinct().ToArray();
                    }
                }
                if (commands[i].Contains("Replace"))
                {
                    string[] replaceArr = commands[i].Split(' ');
                    if (replaceArr[0] == "Replace")
                    {
                        int removeNumber = int.Parse(replaceArr[1]);
                        input[removeNumber] = replaceArr[2];
                    }
                }
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }

}
