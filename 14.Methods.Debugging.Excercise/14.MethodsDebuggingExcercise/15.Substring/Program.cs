using System;


namespace _15.Substring
{

    static class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            bool hasMatch = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'p')
                {
                    hasMatch = true;
                    int endIndex = count + 1;
                    if (endIndex + i > text.Length)
                    {
                        endIndex = text.Length - i;
                    }
                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += endIndex - 1;
                }
            }
            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }

}