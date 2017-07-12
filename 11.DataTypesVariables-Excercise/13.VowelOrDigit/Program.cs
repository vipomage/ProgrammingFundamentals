using System;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            try
            {
                int.Parse(input);
                Console.WriteLine("digit");
            }
            catch (Exception)
            {
                switch (input)
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        Console.WriteLine("vowel"); break;
                    default:
                        Console.WriteLine("other");
                        break;
                }
            }
        }
    }
}
