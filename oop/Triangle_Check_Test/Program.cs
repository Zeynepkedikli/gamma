using System;

class TriangleTest
{
    static void Main()
    {
        Console.WriteLine("=== Triangle Test 1 (Valid Triangle) ===");
        int a1 = 3, b1 = 4, c1 = 5;
        if (a1 + b1 > c1 && b1 + c1 > a1 && c1 + a1 > b1)
        {
            Console.WriteLine("{0}, {1}, {2}: Valid triangle", a1, b1, c1);
            if (a1 * a1 + b1 * b1 == c1 * c1)
                Console.WriteLine("Right triangle");
        }

        Console.WriteLine("\n=== Triangle Test 2 (Invalid Triangle) ===");
        int a2 = 1, b2 = 2, c2 = 10;
        if (a2 + b2 > c2 && b2 + c2 > a2 && c2 + a2 > b2)
        {
            Console.WriteLine("{0}, {1}, {2}: Valid triangle", a2, b2, c2);
        }
        else
        {
            Console.WriteLine("{0}, {1}, {2}: Not valid", a2, b2, c2);
        }

        Console.WriteLine("\n=== Triangle Test 3 (Valid but not Right) ===");
        int a3 = 5, b3 = 6, c3 = 7;
        if (a3 + b3 > c3 && b3 + c3 > a3 && c3 + a3 > b3)
        {
            Console.WriteLine("{0}, {1}, {2}: Valid triangle", a3, b3, c3);
            if (a3 * a3 + b3 * b3 == c3 * c3 || c3 * c3 + b3 * b3 == a3 * a3 || a3 * a3 + c3 * c3 == b3 * b3)
                Console.WriteLine("Right triangle");
            else
                Console.WriteLine("Not a right triangle");
        }
    }
}