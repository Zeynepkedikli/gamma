using System;

class PrimeCounterTest
{
    static bool CheckIfPrime(int number)
    {
        if (number < 2) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        int limit = (int)Math.Sqrt(number);
        for (int divisor = 3; divisor <= limit; divisor += 2)
            if (number % divisor == 0) return false;

        return true;
    }

    static void Main()
    {
        int[] ranges = { 100, 500, 1000 };

        foreach (int range in ranges)
        {
            int count = 0;
            for (int num = 2; num <= range; num++)
                if (CheckIfPrime(num)) count++;

            Console.WriteLine("Primes up to {0}: {1}", range, count);
        }
    }
}