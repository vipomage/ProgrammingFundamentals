using System;
using System.Linq;

namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            var str1 = input[0];
            var str2 = input[1];
            var result = AreExchangeable(str1, str2);

            Console.WriteLine(result ? "true" : "false");
        }
        public static Boolean AreExchangeable(string str1, string str2)
        {
            bool areExchangeable = false;
            var newStr1 = str1.Distinct().ToArray();
            var newStr2 = str2.Distinct().ToArray();
            if ( newStr1.Length == newStr2.Length )
            {
                areExchangeable = true;
            }
            return areExchangeable;
        }
    }
}