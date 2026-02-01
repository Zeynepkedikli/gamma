using System;

public class Lib2
{
    // Power fonksiyonu
    public static double Power(double baseNum, int exponent)
    {
        // Negatif üs kontrolü
        if (exponent < 0)
        {
            return 1.0 / Power(baseNum, -exponent);
        }

        // Üs 0 ise sonuç 1
        if (exponent == 0)
        {
            return 1;
        }

        double result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNum;
        }

        return result;
    }

    // Main metodu
    static void Main(string[] args)
    {
        Console.WriteLine("=== Power Fonksiyonu Manuel Test ===");
        Console.WriteLine($"2^3 = {Power(2, 3)}");      // 8
        Console.WriteLine($"5^2 = {Power(5, 2)}");      // 25
        Console.WriteLine($"10^0 = {Power(10, 0)}");    // 1
        Console.WriteLine($"3^4 = {Power(3, 4)}");      // 81
        Console.WriteLine($"1^100 = {Power(1, 100)}");  // 1
    }
}