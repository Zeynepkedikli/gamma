using System;

class PrimeCounter
{
    static bool CheckIfPrime(int number)
    {
        if (number < 2)
            return false;

        if (number == 2)
            return true;

        if (number % 2 == 0)
            return false;

        int limit = (int)Math.Sqrt(number);
        for (int divisor = 3; divisor <= limit; divisor += 2)
        {
            if (number % divisor == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        int count = 0;
        int maxRange = 1000;

        for (int num = 2; num <= maxRange; num++)
        {
            if (CheckIfPrime(num))
                count++;
        }

        Console.WriteLine($"Total prime numbers up to {maxRange}: {count}");
    }
}