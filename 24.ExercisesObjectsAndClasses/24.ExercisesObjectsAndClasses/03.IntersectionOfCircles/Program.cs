using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.IntersectionOfCircles
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = ReadCircle();
            Circle c2 = ReadCircle();

            if ( Intersect(c1, c2) )
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static Circle ReadCircle()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point center = new Point();
            center.X = input[0];
            center.Y = input[1];
            Circle c1 = new Circle()
            {
                Center = center,
            };
            c1.Radius = input[2];
            return c1;
        }

        static decimal DistanceBetweenPoints(Point p1, Point p2)
        {   
            decimal distance = (decimal)Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            return distance;
        }

        static bool Intersect(Circle c1, Circle c2)
        {
            if ( DistanceBetweenPoints(c1.Center, c2.Center) <= c1.Radius + c2.Radius )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
