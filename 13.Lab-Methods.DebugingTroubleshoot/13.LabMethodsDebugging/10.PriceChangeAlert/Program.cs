using System;


internal class PriceChangeAlert
{


    private static string Get(double currentPrice, double lastPrice, double difference, bool oveThreshold)
    {
        string change = string.Empty;
        if (difference == 0)
            change = $"NO CHANGE: {currentPrice}";
        else if (!oveThreshold)
            change = $"MINOR CHANGE: {lastPrice} to {currentPrice} ({difference:F2}%)";
        else if (oveThreshold && difference > 0)
            change = $"PRICE UP: {lastPrice} to {currentPrice} ({difference:F2}%)";
        else if (oveThreshold && difference < 0)
            change = $"PRICE DOWN: {lastPrice} to {currentPrice} ({difference:F2}%)";
        return change;
    }




    private static bool checkThreshold(double value, double threshold)
    {
        if (Math.Abs(value) >= threshold * 100)
            return true;
        
        return false;
    }




    private static double Percent(double lastPrice, double currentPrice)
    {
        double result = ( currentPrice - lastPrice ) / lastPrice * 100;
        return result;
    }




    private static void Main()
    {
        int priceNumbers = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        for (int i = 0; i < priceNumbers - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double percentDifference = Percent(price, currentPrice);
            bool overThreshold = checkThreshold(percentDifference, threshold);
            string message = Get(currentPrice, price, percentDifference, overThreshold);
            Console.WriteLine(message);
            price = currentPrice;
        }
    }


}