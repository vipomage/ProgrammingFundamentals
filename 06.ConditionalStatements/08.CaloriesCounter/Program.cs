using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            double cheese  = 500;
            double tomatoS = 150;
            double salami  = 600;
            double pepper  = 50;
            double totalCk = 0;
            int n = int.Parse(Console.ReadLine());
             
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "cheese":totalCk += cheese;break;
                    case "tomato sauce":totalCk += tomatoS;break;
                    case "salami": totalCk += salami;break;
                    case "pepper": totalCk += pepper;break;
                }
            }
            Console.WriteLine($"Total calories: {totalCk}");
        }
    }
}
