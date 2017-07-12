using System;

namespace _11.GeometryCalculator
{

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "triangle":
                    Console.WriteLine($"{ReturnTriangleArea():F2}"); break;

                case "square":
                    Console.WriteLine($"{ReturnSquareArea():F2}"); break;

                case "rectangle":
                    Console.WriteLine($"{ReturnRectangleArea():F2}"); break;

                case "circle":
                    Console.WriteLine($"{ReturnCircleArea():F2}"); break;
            }
        }

        static double ReturnSquareArea()
        {
            double x = double.Parse(Console.ReadLine());
            double volume = Math.Pow(x, 2);
            return volume;
        }

        static double ReturnTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());

            double area = (lenght * side) / 2;
            return area;
        }

        static double ReturnRectangleArea()
        {

            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;
            return area;
        }

        static double ReturnCircleArea()
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * (Math.Pow(r, 2));
            return area;
        }
    }
}
