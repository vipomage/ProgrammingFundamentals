using System;
using System.Linq;

namespace _02.CommandInterpreter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] command = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            while ( command[0].ToLower() != "end" )
            {
                if ( command.Length < 3 && command[0].ToLower() != "end" )
                {
                    Console.WriteLine("Invalid input parameters.");
                    command = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                }
                else
                {
                    try
                    {
                        switch ( command[0].ToLower() )
                        {
                            case "reverse":
                                Reverse(inputArr, int.Parse(command[2]), int.Parse(command[4]));
                                break;
                            case "sort":
                                Sort(inputArr, int.Parse(command[2]), int.Parse(command[4]));
                                break;
                            case "rollleft":
                                RollLeft(inputArr, int.Parse(command[1]));
                                break;
                            case "rollright":
                                RollRight(inputArr, int.Parse(command[1]));
                                break;
                            case "end":
                                break;
                        }
                        command = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    }
                    catch ( Exception )
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    }
                }
            }
            Console.WriteLine($"[{string.Join(", ", inputArr)}]");
        }

        static void Reverse(string[] array, int startIndex, int endIndex)
        {
            string[] reverseArray = new string[endIndex];

            for ( int i = 0; i < endIndex; i++ )
            {
                reverseArray[i] = array[startIndex + i];
            }
            Array.Reverse(reverseArray);
            for ( int i = 0; i < endIndex; i++ )
            {
                array[startIndex + i] = reverseArray[i];
            }
        }

        public static void Sort(string[] array, int startIndex, int endIndex)
        {
            string[] sortArray = new string[endIndex];

            for ( int i = 0; i < endIndex; i++ )
            {
                sortArray[i] = array[startIndex + i];
            }
            sortArray = sortArray.OrderBy(a => a).ToArray();

            for ( int i = 0; i < endIndex; i++ )
            {
                array[startIndex + i] = sortArray[i];
            }
        }

        static void RollLeft(string[] array, int times)
        {
            for ( int j = 0; j < times % array.Length; j++ )
            {
                string temp = array[0];

                for ( int i = 0; i < array.Length - 1; i++ )
                {
                    array[i] = array[i + 1];
                }

                array[array.Length - 1] = temp;
            }
        }

        static void RollRight(string[] array, int times)
        {
            for ( int j = 0; j < times % array.Length; j++ )
            {
                string temp = array[array.Length - 1];

                for ( int i = array.Length - 1; i > 0; i-- )
                {
                    array[i] = array[i - 1];
                }
                array[0] = temp;
            }
        }
    }
}
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            var inputStrings = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "end")
                {
                    break;
                }

                var commands = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var command = commands.First();
                var index = 0;
                var count = 0;

                if (commands.Length == 5)
                {
                    index = int.Parse(commands[2]);
                    count = int.Parse(commands[4]);



                    if (index < 0 || index >= inputStrings.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }

                    if (count < 0 || count > inputStrings.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }

                    if ((index + count) > inputStrings.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                }
                else if (commands.Length == 2)
                {
                    count = int.Parse(commands[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input parameters.");
                    continue;
                }

                var subListStrings = new List<string>();

                switch (command)
                {
                    case "reverse":
                        subListStrings = inputStrings.Skip(index).Take(count).ToList();

                        for (int i = 0; i < subListStrings.Count / 2; i++)
                        {
                            var tempStr = string.Empty;
                            tempStr = subListStrings[i];
                            subListStrings[i] = subListStrings[subListStrings.Count - 1 - i];
                            subListStrings[subListStrings.Count - 1 - i] = tempStr;
                        }

                        inputStrings.RemoveRange(index, count);
                        inputStrings.InsertRange(index, subListStrings);

                        break;
                    case "sort":
                        subListStrings = inputStrings.Skip(index).Take(count).ToList();
                        subListStrings.Sort();

                        inputStrings.RemoveRange(index, count);
                        inputStrings.InsertRange(index, subListStrings);

                        break;
                    case "rollLeft":

                        var rollCountL = count % inputStrings.Count;

                        for (int i = 0; i < rollCountL; i++)
                        {
                            inputStrings.Add(inputStrings[0]);
                            inputStrings.RemoveAt(0);
                        }

                        break;
                    case "rollRight":

                        var rollCountR = count % inputStrings.Count;

                        for (int i = 0; i < rollCountR; i++)
                        {
                            inputStrings.Insert(0, inputStrings.Last());
                            inputStrings.RemoveAt(inputStrings.Count - 1);
                        }

                        break;
                    default:
                        Console.WriteLine("Invalid input parameters.");
                        break;
                }
            }

            Console.WriteLine("[{0}]", String.Join(", ", inputStrings));
        }
    }
}
 * 
 */
