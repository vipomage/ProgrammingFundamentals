using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace _16.InstructionSet
{

    class Program
    {
        static void Main(string[] args)
        {
            INPUT:
            string opCode = Console.ReadLine().ToLower();
            while(opCode != "end")
            {
                string[] codeArgs = opCode.Split(' ');
                BigInteger result = 0;
                switch (codeArgs[0])
                {
                    case "inc":
                    {
                        BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                        result = ++operandOne;
                        break;
                    }
                    case "dec":
                    {
                        BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                        result = --operandOne;
                        break;
                    }
                    case "add":
                    {
                        BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                        BigInteger operandTwo = BigInteger.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                    case "mla":
                    {
                        BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                        BigInteger operandTwo = BigInteger.Parse(codeArgs[2]);
                        result = ( operandOne * operandTwo );
                        break;
                    }
                }
                Console.WriteLine(result);
                goto INPUT;
            }
        }
    }

}
