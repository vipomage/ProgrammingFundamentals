using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initialArray = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            while (initialArray.Count != 0)
            {
                int actionindex = int.Parse(Console.ReadLine());

                if (actionindex < 0)
                {
                    sum += initialArray[0];
                    int value = initialArray[0];
                    initialArray[0] = initialArray[initialArray.Count-1];
                    for ( int j = 0; j <= initialArray.Count - 1; j++ )
                    {
                        if ( initialArray[j] <= value )
                        {
                            initialArray[j] += value;
                        }
                        else
                        {
                            initialArray[j] -= value;
                        }
                    }
                }
                else if (actionindex > initialArray.Count-1)
                {
                    sum += initialArray[initialArray.Count-1];
                    int value = initialArray[initialArray.Count - 1];
                    initialArray[initialArray.Count-1] = initialArray[0];

                    for ( int j = 0; j <= initialArray.Count - 1; j++ )
                    {
                        if ( initialArray[j] <= value )
                        {
                            initialArray[j] += value;
                        }
                        else
                        {
                            initialArray[j] -= value;
                        }
                    }
                }


                else if (actionindex >= 0 && actionindex <= initialArray.Count-1)
                {
                    sum += initialArray[actionindex];
                    int value = initialArray[actionindex];
                    for (int j = 0; j <= initialArray.Count - 1; j++)
                    {
                        if (initialArray[j] <= value)
                        {
                            initialArray[j] += value;
                        }
                        else
                        {
                            initialArray[j] -= value;
                        }
                    }
                    initialArray.RemoveAt(actionindex);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
