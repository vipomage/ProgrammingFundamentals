using System;
using System.Linq;


namespace _05.ClosestTwoPoints
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
            Point[] points = ReadPoints();
            Point[] closestPoints = FindClosestTwoPoints(points);

            PrintDistance(closestPoints);

            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
        }

        static double CalcDistanceBetweenPoints(Point p1, Point p2)
        {
            double deltaX = p2.X - p1.X;
            double deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
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

        static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            for ( int i = 0; i < n; i++ )
            {
                points[i] = ReadPoint();
            }
            return points;
        }

        static void PrintPoint(Point point)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }

        static void PrintDistance(Point[] points)
        {
            double distance = CalcDistanceBetweenPoints(points[0], points[1]);

            {
                Console.WriteLine($"{distance:F3}");
            }
        }

        static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;
            for ( int p1 = 0; p1 < points.Length; p1++ )
            {
                for ( int p2 = p1 + 1; p2 < points.Length; p2++ )
                {
                    double distance = CalcDistanceBetweenPoints(points[p1], points[p2]);
                    if ( distance < minDistance )
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[p1], points[p2] };
                    }
                }
            }
            return closestTwoPoints;
        }
    }
}
