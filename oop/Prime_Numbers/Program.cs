using System;

class PrimeDisplay
{
    static bool IsPrimeNumber(int value)
    {
        if (value <= 1)
            return false;

        int divisor = 2;
        while (divisor * divisor <= value)
        {
            if (value % divisor == 0)
                return false;
            divisor++;
        }

        return true;
    }

    static void Main()
    {
        int upperBound = 20;
        string primeList = "";

        for (int j = 2; j <= upperBound; j++)
        {
            if (IsPrimeNumber(j))
            {
                primeList += j + ", ";
            }
        }

        if (primeList.Length > 0)
            primeList = primeList.Substring(0, primeList.Length - 2);

        Console.WriteLine("Prime numbers: " + primeList);
    }
}