using System;

public class Program
{
    // En büyük sayıyı bulan fonksiyon
    public static int TheBiggest(int a, int b, int c)
    {
        int m;

        if (a >= b)
        {
            m = a;
        }
        else
        {
            m = b;
        }

        if (m <= c)
        {
            m = c;
        }

        return m;
    }

    // Main metodu
    static void Main(string[] args)
    {
        Random random = new Random();

        int a = random.Next(1, 1001);  // 1-1000 arası
        int b = random.Next(1, 1001);
        int c = random.Next(1, 1001);

        Console.WriteLine($"Sayilar: {a}, {b}, {c}");
        Console.WriteLine($"En buyugu: {TheBiggest(a, b, c)}");

        Console.ReadKey();
    }
}