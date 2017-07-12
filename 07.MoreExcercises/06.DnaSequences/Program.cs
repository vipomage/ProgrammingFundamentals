using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DnaSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int na = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        if (i + j + k >= na)
                        {
                            string v1 = null, v2 = null, v3 = null;

                            switch (i)
                            {
                                case 1: v1 = "A"; break;
                                case 2: v1 = "C"; break;
                                case 3: v1 = "G"; break;
                                case 4: v1 = "T"; break;
                            }
                            switch (j)
                            {
                                case 1: v2 = "A"; break;
                                case 2: v2 = "C"; break;
                                case 3: v2 = "G"; break;
                                case 4: v2 = "T"; break;
                            }
                            switch (k)
                            {
                                case 1: v3 = "A"; break;
                                case 2: v3 = "C"; break;
                                case 3: v3 = "G"; break;
                                case 4: v3 = "T"; break;
                            }
                            if (count % 4 == 0)
                            {
                                Console.WriteLine();
                                Console.Write($"O{v1}{v2}{v3}O ");
                                count++;
                            }
                            else
                            {
                                Console.Write($"O{v1}{v2}{v3}O ");
                                count++;
                            }
                        }
                        else
                        {
                            string v1 = null, v2 = null, v3 = null;

                            switch (i)
                            {
                                case 1: v1 = "A"; break;
                                case 2: v1 = "C"; break;
                                case 3: v1 = "G"; break;
                                case 4: v1 = "T"; break;
                            }
                            switch (j)
                            {
                                case 1: v2 = "A"; break;
                                case 2: v2 = "C"; break;
                                case 3: v2 = "G"; break;
                                case 4: v2 = "T"; break;
                            }
                            switch (k)
                            {
                                case 1: v3 = "A"; break;
                                case 2: v3 = "C"; break;
                                case 3: v3 = "G"; break;
                                case 4: v3 = "T"; break;
                            }
                            if (count % 4 == 0)
                            {
                                Console.WriteLine();
                                Console.Write($"X{v1}{v2}{v3}X ");
                                count++;
                            }
                            else
                            {
                                Console.Write($"X{v1}{v2}{v3}X ");
                                count++;
                            }
                        }
                    }
                }
            }
        }
    }
}
