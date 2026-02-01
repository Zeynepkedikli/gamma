using System;

class PiHesaplayici
{
    static double LeibnitzYontemi(int iterasyon)
    {
        double toplam = 0;
        int isaret = 1;
        int payda = 1;

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
        {
            toplam += 1.0 / (j * j);
        }
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
        double gercekPi = 3.141592;
        int testSayisi = 100;

        Console.WriteLine("=== Pi Hesaplamalari ===");
        Console.WriteLine("Leibnitz ({0} iterasyon): {1}", testSayisi, LeibnitzYontemi(testSayisi));
        Console.WriteLine("Euler ({0} iterasyon): {1}", testSayisi, EulerYontemi(testSayisi));
        Console.WriteLine("Wallis ({0} iterasyon): {1}", testSayisi, WallisYontemi(testSayisi));
    }
}