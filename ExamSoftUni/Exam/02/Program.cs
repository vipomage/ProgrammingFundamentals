using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            while (true)
            {
                MatchCollection didimonCollection = Regex.Matches(input, "[^-A-Za-z]+");
                for (int i = 0; i < 1; i++)
                {
                    if (didimonCollection.Count > 0)
                    {
                        Console.WriteLine(didimonCollection[0]);
                        input = input.Substring(didimonCollection[0].Index + didimonCollection[0].Length);
                    }
                    else
                    {
                        return;
                    }
                }
                MatchCollection bojoCollection = Regex.Matches(input, "[\\w]+\\-[\\w]+");
                for (int i = 0; i < 1; i++)
                {
                    if (bojoCollection.Count > 0)
                    {
                        Console.WriteLine(bojoCollection[0]);
                        input = input.Substring(bojoCollection[0].Index + bojoCollection[0].Length);
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}
