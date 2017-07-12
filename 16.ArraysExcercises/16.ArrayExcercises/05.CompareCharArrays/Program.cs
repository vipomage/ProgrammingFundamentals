using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _05.CompareCharArrays
{

    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int shorter = Math.Min(arr1.Length, arr2.Length);
            int equalLenght = 0;
            char[] shorterArr = null;
            char[] longerArr = null;
            int count = 0;
            bool equal = false;
            for (int i = 0; i < shorter; i++)
            {
                equal = false;
                if ( arr1[i] == arr2[i] )
                {
                    equalLenght++;
                    equal = true;
                }
                else
                {
                    break;
                }
                count++;
            }
            //if (arr1.Length == arr2.Length && equal)
            //{
            //    shorterArr = arr2;
            //    longerArr = arr1;
            //}
            //else if (arr1.Length == arr2.Length && !equal)
            //{
            //    shorterArr = arr2;
            //    longerArr = arr1;
            //}
            //else if (arr1.Length < arr2.Length && equal)
            //{
            //    shorterArr = arr1;
            //    longerArr = arr2;
            //}
            //else
            //{
            //    shorterArr = arr2;
            //    longerArr = arr1;
            //}
            string myFirstWord = String.Empty;
            string mySecondWord = String.Empty;
            for (int i = 0; i < arr1.Length; i++)
            {
                myFirstWord += arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                mySecondWord += arr2[i];
            }
            string sum = string.Join(" ", myFirstWord, mySecondWord);
            string[] arrayofSum = sum.Split(' ').ToArray();
            Array.Sort(arrayofSum);
            Console.WriteLine($"{arrayofSum[0]}\n{arrayofSum[1]}");
        }
    }

}
