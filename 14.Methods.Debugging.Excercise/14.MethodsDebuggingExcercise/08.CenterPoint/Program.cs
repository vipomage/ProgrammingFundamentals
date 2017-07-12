using System;

class Program
{
    static void Main()
    {

        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        Console.WriteLine(ReturnClosestPointsToOrigin(x1, y1, x2, y2));
    }

    static string ReturnClosestPointsToOrigin(double x1, double y1, double x2, double y2)
    {
        string result = string.Empty;

        double xy1 = ReturnPointDistanceToOrigin(x1, y1);
        double xy2 = ReturnPointDistanceToOrigin(x2, y2);

        if (xy1 < xy2)
        {
            result = $"({x1}, {y1})";
        }
        else
        {
            result = $"({x2}, {y2})";
        }
        return result;
    }

    static double ReturnPointDistanceToOrigin(double x, double y)
    {
        double distance = Math.Abs(Math.Pow(x, 2)) + Math.Abs(Math.Pow(y, 2));
        return Math.Sqrt(distance);
    }
}