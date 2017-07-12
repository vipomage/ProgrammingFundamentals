using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimesinGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            PrimeInRange(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            foreach (int i in MyList)
            {
                count++;
                if (count == MyList.Count)
                {
                    Console.Write($"{i}");
                }
                else
                {
                    Console.Write($"{i}, ");
                }
            }
        }
        static List<int> MyList = new List<int>();

        static void PrimeInRange(int st, int en)
        {
            for (int i = st; i <= en; i++)
            {
                int cnt = 0;
                for (int j = 1; j <= en; j++)
                {
                    if (i % j == 0)
                    {
                        cnt++;
                    }
                }
                if (cnt == 2)
                {
                    MyList.Add(i);
                }
                cnt = 0;
            }
        }
    }
}
