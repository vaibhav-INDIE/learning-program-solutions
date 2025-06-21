using System;

class Program
{


    static double PredictFutureValue(double initialAmount, double rate, int years)
    {

        if (years == 0)
            return initialAmount;

        return PredictFutureValue(initialAmount, rate, years - 1) * (1 + rate);
    }

    static void Main()
    {
        double initial = 1000;
        double rate = 0.05; // assuming 5% annual growth
        int years = 5;

        double futureValue = PredictFutureValue(initial, rate, years);
        Console.WriteLine($"Future Value after {years} years: Rs{futureValue:F2}");
    }
}