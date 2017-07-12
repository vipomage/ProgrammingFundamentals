using System;
using System.Linq;

namespace _04.DistanceBetweenPoints
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();
            Console.WriteLine($"{CalcDistance(p1, p2):F3}");
        }

        static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point point = new Point
            {
                X = pointInfo[0],
                Y = pointInfo[1]
            };
            return point;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            double deltaX = p2.X - p1.X;
            double deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}