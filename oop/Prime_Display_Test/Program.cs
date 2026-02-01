using System;

class PrimeDisplayTest
{
    static bool IsPrimeNumber(int value)
    {
        if (value <= 1) return false;

        int divisor = 2;
        while (divisor * divisor <= value)
        {
            if (value % divisor == 0) return false;
            divisor++;
        }
        return true;
    }

    static void Main()
    {
        int[] ranges = { 20, 50, 100 };

        foreach (int range in ranges)
        {
            Console.Write("Primes up to {0}: ", range);
            for (int j = 2; j <= range; j++)
                if (IsPrimeNumber(j)) Console.Write(j + " ");
            Console.WriteLine();
        }
    }
}