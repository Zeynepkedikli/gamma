using System;

class FibonacciTest
{
    static int GetFib(int num)
    {
        if (num <= 2) return 1;

        int first = 1, second = 1, result = 0;
        for (int j = 3; j <= num; j++)
        {
            result = first + second;
            first = second;
            second = result;
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine("=== Fibonacci Tests ===");
        Console.WriteLine("fib(1) = {0}", GetFib(1));
        Console.WriteLine("fib(2) = {0}", GetFib(2));
        Console.WriteLine("fib(3) = {0}", GetFib(3));
        Console.WriteLine("fib(4) = {0}", GetFib(4));
        Console.WriteLine("fib(5) = {0}", GetFib(5));
    }
}