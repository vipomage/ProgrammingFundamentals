using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativesNdReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myNumList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> myResullList  = new List<string>();
            
            
            foreach (int positive in myNumList )
            {
                if ( positive >=0 )
                {
                    myResullList.Add(positive.ToString());
                }
            }
            myResullList.Reverse();
            if (myResullList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ",myResullList));
                
            }
        }
    }
}
