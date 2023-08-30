using System;

namespace PriceChangeAlert
{
    class Program
    {
        //Code to refactor

        //static void Main()
        //{
        //    int n = int.Parse(Console.ReadLine());
        //    double granica = double.Parse(Console.ReadLine());
        //    double last = double.Parse(Console.ReadLine());

        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        double c = double.Parse(Console.ReadLine());
        //        double div = Proc(last, c); bool isSignificantDifference = imaliDif(div, granica);



        //        string message = Get(c, last, div, isSignificantDifference);
        //        Console.WriteLine(message);

        //        last = c;
        //    }
        //}

        //private static string Get(double c, double last, double razlika, bool etherTrueOrFalse)
        //{
        //    string to = "";
        //    if (razlika == 0)
        //    {
        //        to = string.Format("NO CHANGE: {0}", c);
        //    }
        //    else if (!etherTrueOrFalse)
        //    {
        //        to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, c, razlika);
        //    }
        //    else if (etherTrueOrFalse && (razlika > 0))
        //    {
        //        to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, c, razlika);
        //    }
        //    else if (etherTrueOrFalse && (razlika < 0))
        //        to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, c, razlika);
        //    return to;
        //}

        //private static bool imaliDif(double granica, double isDiff)
        //{
        //    if (Math.Abs(granica) >= isDiff * 100)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //private static double Proc(double l, double c)
        //{
        //    double r = (c - l) / l;
        //    return r * 100;
        //}

        static void Main()
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double percent = Percentage(lastPrice, currentPrice); 
                bool isSignificantDifference = isThereDifference(percent, threshold);

                string results = GetResults(currentPrice, lastPrice, percent, isSignificantDifference);
                Console.WriteLine(results);

                lastPrice = currentPrice;
            }
        }

        private static string GetResults(double currentPrice, double lastPrice, double percent, bool isSignificantDifference)
        {
            string results = string.Empty;

            if (percent == 0)
            {
                results = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isSignificantDifference)
            {
                results = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, percent);
            }
            else if (isSignificantDifference && (percent > 0))
            {
                results = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, percent);
            }
            else if (isSignificantDifference && (percent < 0))
            {
                results = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, percent);
            }

            return results;
        }

        private static bool isThereDifference(double percent, double threshold)
        {
            if (Math.Abs(percent) >= threshold * 100)
            {
                return true;
            }
            return false;
        }

        private static double Percentage(double lastPrice, double currentPrice)
        {
            double priceDifference = (currentPrice - lastPrice) / lastPrice;
            return priceDifference * 100;
        }
    }
}
