using System;

namespace _12.RectanglePorperties
{
    class Program
    {
        static void Main(string[] args)
        {//INPUT
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            //OUTPUT
            double perimeter = (width+height)*2;
            double area = width * height;
            double diagonal = Math.Sqrt(Math.Pow(width,2)+Math.Pow(height,2));
            Console.WriteLine($"{perimeter}\n{area}\n{diagonal}");
        }
    }
}
