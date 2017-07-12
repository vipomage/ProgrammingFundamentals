using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int pesho = int.Parse(Console.ReadLine());
            int gosho = int.Parse(Console.ReadLine());
            int peshoHp = 100;
            int goshoHp = 100;
            int round = 1;
            bool HP = true;
        statement:
            if (goshoHp >= 0 && peshoHp >= 0)
            {
                if (round % 2 == 1)
                {//Pesho
                    goshoHp -= pesho;
                    if (goshoHp > 0)
                    {
                        Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", goshoHp);
                        if (round % 3 == 0)
                        {
                            peshoHp += 10;
                            goshoHp += 10;
                        }
                        round++;
                    }
                    else
                    {
                        Console.WriteLine("Pesho won in {0}th round.", round);
                        goto end;
                    }
                }
                if (round % 2 == 0)
                {//Gosho
                    peshoHp -= gosho;
                    if (peshoHp > 0)
                    {
                        Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", peshoHp);
                        if (round % 3 == 0)
                        {
                            goshoHp += 10;
                            peshoHp += 10;
                        }
                        round++;
                    }
                    else
                    {
                        Console.WriteLine("Gosho won in {0}th round.", round);
                        goto end;
                    }
                }
                goto statement;
            end:
                ;
            }
        }
    }
}