using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] field = new int[size];

            string[] initialField = Console.ReadLine().Split();
            foreach ( string t in initialField )
            {
                try
                {
                    field[int.Parse(t)] = 1;
                }
                catch ( Exception )
                {
                    /*ignored */
                }
            }

            string input = Console.ReadLine();

            while ( input.ToLower() != "end" )
            {
                int addition = 0;
                string[] array = input.Split();
                
                try
                {
                    if ( array[1].ToLower() == "right" )
                    {
                        if ( field[int.Parse(array[0])] != 0 )
                        {
                            field[int.Parse(array[0])] = 0;
                            for ( int i = int.Parse(array[0]); i < field.Length - 1; i++ )
                            {
                                if ( field[i + int.Parse(array[2])] == 0 )
                                {
                                    field[i + int.Parse(array[2])+(addition)/2] = 1;
                                    addition = 0;
                                    break;
                                }
                                else
                                {
                                    addition++;
                                }
                                
                            }
                        }
                    }
                    if ( array[1].ToLower() == "left" )
                    {
                        if ( field[int.Parse(array[0])] != 0 )
                        {
                            field[int.Parse(array[0])] = 0;
                            for ( int i = int.Parse(array[0]); i >=0; i-- )
                            {
                                
                                if ( field[i - int.Parse(array[2])] == 0 )
                                {
                                    field[i - int.Parse(array[2])+(addition)/2] = 1;
                                    addition = 0;
                                    break;
                                }
                                else
                                {
                                    addition --;
                                }
                            }
                        }
                    }
                    //Console.WriteLine(string.Join(" ", field));


                    input = Console.ReadLine();
                }
                catch ( Exception )
                {
                    //Console.WriteLine(string.Join(" ", field));
                    input = Console.ReadLine();
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
