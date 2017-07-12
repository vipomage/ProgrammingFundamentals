using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VaporStore
{
    class Program
    {
        static bool BalanceCheck(double a)
        {
            bool balance = true;
            if (a >= 0)
            {
                balance = false;
            }
            return balance;
        }

        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string gameName = String.Empty;
            double spent = 0;
            bool balanceLeft = true;
            while (balance > 0)
            {
                gameName = Console.ReadLine();

                switch (gameName)
                {
                    case "OutFall 4":
                        if (balance < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        else
                        {
                            balance -= 39.99;
                            spent += 39.99;
                            Console.WriteLine("Bought OutFall 4");
                            if (!balanceLeft == BalanceCheck(balance))
                            {
                                break;
                            }
                            continue;
                        }
                    case "CS: OG":
                        if (balance < 15.99)
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        else
                        {
                            balance -= 15.99;
                            spent += 15.99;
                            Console.WriteLine("Bought CS: OG");
                            if (!balanceLeft == BalanceCheck(balance))
                            {
                                break;
                            }
                            continue;
                        }
                    case "Zplinter Zell":
                        if (balance < 19.99)
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        else
                        {
                            balance -= 19.99;
                            spent += 19.99;
                            Console.WriteLine("Bought Zplinter Zell");
                            if (!balanceLeft == BalanceCheck(balance))
                            {
                                break;
                            }
                            continue;
                        }
                    case "Honored 2":
                        if (balance < 59.99)
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        else
                        {
                            balance -= 59.99;
                            spent += 59.99;
                            Console.WriteLine("Bought Honored 2");
                            if (!balanceLeft == BalanceCheck(balance))
                            {
                                break;
                            }
                            continue;
                        }
                    case "RoverWatch":
                        if (balance < 29.99)
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        else
                        {
                            balance -= 29.99;
                            spent += 29.99;
                            Console.WriteLine("Bought RoverWatch");
                            if (!balanceLeft == BalanceCheck(balance))
                            {
                                break;
                            }
                            continue;
                        }
                    case "RoverWatch Origins Edition":
                        if (balance < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        else
                        {
                            balance -= 39.99;
                            spent += 39.99;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                            if (!balanceLeft == BalanceCheck(balance))
                            {
                                break;
                            }
                            continue;
                        }
                    case "Game Time":
                        Console.WriteLine($"Total spent: ${spent:F2}. Remaining: ${balance:F2}"); return;
                    default:
                        Console.WriteLine("Not Found"); continue;
                }
            }
            Console.WriteLine("Out of money!");
            return;
        }
    }
}
