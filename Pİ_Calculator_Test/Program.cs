using System;

class PiTest
{
    static double LeibnitzYontemi(int iterasyon)
    {
        double toplam = 0;
        int isaret = 1, payda = 1;
        for (int j = 0; j < iterasyon; j++)
        {
            toplam += isaret * (1.0 / payda);
            payda += 2;
            isaret *= -1;
        }
        return toplam * 4;
    }

    static double EulerYontemi(int iterasyon)
    {
        double toplam = 0;
        for (int j = 1; j <= iterasyon; j++)
            toplam += 1.0 / (j * j);
        return Math.Sqrt(6 * toplam);
    }

    static double WallisYontemi(int iterasyon)
    {
        double carpim = 1;
        for (int j = 1; j <= iterasyon; j++)
        {
            double pay = 2.0 * j;
            carpim *= (pay / (pay - 1)) * (pay / (pay + 1));
        }
        return carpim * 2;
    }

    static void Main()
    {
        int[] tests = { 100, 1000 };

        foreach (int t in tests)
        {
            Console.WriteLine("Iterations: {0}", t);
            Console.WriteLine("Leibnitz: {0:F4}", LeibnitzYontemi(t));
            Console.WriteLine("Euler: {0:F4}", EulerYontemi(t));
            Console.WriteLine("Wallis: {0:F4}", WallisYontemi(t));
            Console.WriteLine();
        }
    }
}