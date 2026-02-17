using System;
namespace LaboratoryWork2nd;

public static class Program
{
    static void Main(string[] args)
    {
        Func<double, double> discountCalculator = null;

        discountCalculator += (price) => price * 0.95;  // -5%
        discountCalculator += (price) => price * 0.90;  // -10%
        discountCalculator += (price) => price - 100;   // -100 грн

        double initialPrice = 1000;
        double currentPrice = initialPrice;

        var pipeline = discountCalculator.GetInvocationList();

        foreach (var step in pipeline)
        {
            var func = (Func<double, double>)step;
            currentPrice = func(currentPrice);
        }

        Console.WriteLine($"Фінальна ціна: {currentPrice}");
    }
}