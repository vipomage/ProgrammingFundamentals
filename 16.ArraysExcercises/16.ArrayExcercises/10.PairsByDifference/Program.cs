using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double counter = 0;
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int num = int.Parse(Console.ReadLine());

        foreach (int i in input)
        {
            foreach (int j in input)
            {
                if (j == i)
                {
                    break;
                }
                if ((j + i) == num || (j - i) == num || (i - j) == num)
                {
                    counter++;
                }
            }
        }
        Console.WriteLine(counter);
    }
}
