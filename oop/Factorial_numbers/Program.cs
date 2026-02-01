using System;

class FactorialCalculator
{
    static long ComputeFactorial(int number)
    {
        long product = 1;

        for (int counter = 2; counter <= number; counter++)
        {
            product *= counter;
        }

        return product;
    }

    static long CalculateFactorial(int value)
    {
        if (value <= 1)
            return 1;

        long multiplication = 1;
        int j = 2;

        do
        {
            multiplication *= j;
            j++;
        } while (j <= value);

        return multiplication;
    }

    static void Main()
    {
        int[] testValues = { 6, 0, 25, 5, 4 };

        Console.WriteLine("=== Factorial Calculations ===\n");

        foreach (int num in testValues)
        {
            if (num < 13)
                Console.WriteLine($"{num}! = {ComputeFactorial(num)}");
            else
                Console.WriteLine($"{num}! = {CalculateFactorial(num)}");
        }
    }
}