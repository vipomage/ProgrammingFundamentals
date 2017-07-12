using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            var matches= 
            Regex.Matches("Аз съм Наков, обаче ми се пие бира, ama da e po-hubawa", @"[a-zA-ZА-Яа-я-]+");

            foreach (Match match in matches)
            {
                 Console.WriteLine(match.Groups[0]);
                
            }
            

        }
    }
}
