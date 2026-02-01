using System;

class PiCalculation
{
    static void Main()
    {
        int sign = 1;
        double result = 0;
        int maxIterations = 1000000;
        double actualPi = 3.141592;

        for (int j = 1; j <= maxIterations; j += 2)
        {
            result += 1.0 / (sign * j);
            sign = sign * (-1);
        }

        double calculatedPi = result * 4;
        Console.WriteLine("Calculated Pi: " + calculatedPi);

        double difference = calculatedPi - actualPi;
        Console.WriteLine("Difference: " + Math.Round(difference, 10));

        Console.WriteLine("Pi value: " + Math.Round(4 * result, 4));
    }
}