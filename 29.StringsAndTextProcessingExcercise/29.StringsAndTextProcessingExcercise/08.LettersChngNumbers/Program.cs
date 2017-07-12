using System;
using System.Linq;

namespace _08.LettersChngNumbers
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            decimal output = 0;

            foreach ( string s in input )
            {
                output += SplittingString(s);
            }

            Console.WriteLine($"{output:F2}");
        }

        private static decimal SplittingString(string combination)
        {
            decimal sum = 0;

            char firstChar = combination[0];
            char[] chArray = combination.Skip(1).Take(combination.Length - 2).ToArray();
            int num = int.Parse(string.Join("", chArray));
            char lastChar = combination[combination.Length - 1];


            if ( IsUpperCase(firstChar) )
            {
                sum += num / CharPos(firstChar);
            }
            else
            {
                sum += num * CharPos(firstChar);
            }


            if ( IsUpperCase(lastChar) )
            {
                sum -= CharPos(lastChar);
            }
            else
            {
                sum += CharPos(lastChar);
            }
            return sum;
        }

        static bool IsUpperCase(int character)
        {
            if ( character > 64 && character < 91 )
            {
                return true;
            }
            return false;
        }

        static decimal CharPos(int character)
        {
            int pos = 0;
            if ( character > 64 && character < 91 )
            {
                pos = character - 64;
            }
            if ( character > 96 && character < 123 )
            {
                pos = character - 96;
            }

            return pos;
        }
    }
}

//class Character
//{
//    public int Value { get; set; }

//    public int Position
//    {
//        get
//        {
//            int pos = 0;
//            if ( Value > 64 && Value < 91 )
//            {
//                pos = Value - 64;
//                Uppercase = true;
//            }
//            if ( Value > 96 && Value < 123 )
//            {
//                pos = Value - 96;
//                Uppercase = false;
//            }
//            return pos;

//        }
//    }

//    public bool Uppercase { get; set; }
//}

//string firstCombo = input[0];
//string secondCombo = input[1];

//decimal sum1 = SplittingString(firstCombo);
//decimal sum2 = SplittingString(secondCombo);

//decimal result = sum2 + sum1;
