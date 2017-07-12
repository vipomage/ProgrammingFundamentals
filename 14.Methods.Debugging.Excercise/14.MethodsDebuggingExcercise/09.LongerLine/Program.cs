using System;

namespace _09.LongerLine
{
    class Program
    {
        static void Main()
        {
            //Line 1
            double lineOneX1 = double.Parse(Console.ReadLine());
            double lineOneY1 = double.Parse(Console.ReadLine());
            double lineOneX2 = double.Parse(Console.ReadLine());
            double lineOneY2 = double.Parse(Console.ReadLine());
            //Line 2
            double lineTwoX1 = double.Parse(Console.ReadLine());
            double lineTwoY1 = double.Parse(Console.ReadLine());
            double lineTwoX2 = double.Parse(Console.ReadLine());
            double lineTwoY2 = double.Parse(Console.ReadLine());

            double firstLineLenght = ReturnLengthBetweenTwoPoints(lineOneX1, lineOneY1, lineOneX2, lineOneY2);
            double secondLineLenght = ReturnLengthBetweenTwoPoints(lineTwoX1, lineTwoY1, lineTwoX2, lineTwoY2);



            if (firstLineLenght > secondLineLenght)
            {
                Console.WriteLine(ReturnCloserPoint(lineOneX1, lineOneY1, lineOneX2, lineOneY2));

            }
            else
            {
                Console.WriteLine(ReturnCloserPoint(lineTwoX1, lineTwoY1, lineTwoX2, lineTwoY2));
            }


        }

        private static string ReturnCloserPoint(double x1, double Y1, double X2, double Y2)
        {
            string result = String.Empty;
            double firstPointDistanceToO_XY1 = ReturnPointDistanceToOrigin(x1, Y1);
            double firstPointDistanceToO_XY2 = ReturnPointDistanceToOrigin(X2, Y2);

            if (firstPointDistanceToO_XY1 <= firstPointDistanceToO_XY2)
            {
                result = $"({x1}, {Y1})({X2}, {Y2})";
            }
            else
            {
                result = $"({X2}, {Y2})({x1}, {Y1})";
            }
            return result;
        }

        static double ReturnLengthBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {

            double firstPoint = ReturnPointDistanceToOrigin(x1, y1);
            double secondPoint = ReturnPointDistanceToOrigin(x2, y2);
            double lineLenght = Math.Abs(firstPoint) + Math.Abs(secondPoint);

            return lineLenght;
        }
        static double ReturnPointDistanceToOrigin(double x, double y)
        {
            double distance = Math.Abs(Math.Pow(x, 2)) + Math.Abs(Math.Pow(y, 2));
            return Math.Sqrt(distance);
        }

    }
}
