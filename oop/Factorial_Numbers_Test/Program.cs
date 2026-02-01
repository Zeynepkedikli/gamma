using System;

class FactorialTest
{
    static long ComputeFactorial(int number)
    {
        long product = 1;
        for (int counter = 2; counter <= number; counter++)
            product *= counter;
        return product;
    }

    static void Main()
    {
        Console.WriteLine("=== Factorial Tests ===");
        Console.WriteLine("0! = {0}", ComputeFactorial(0));
        Console.WriteLine("1! = {0}", ComputeFactorial(1));
        Console.WriteLine("5! = {0}", ComputeFactorial(5));
        Console.WriteLine("6! = {0}", ComputeFactorial(6));
        Console.WriteLine("10! = {0}", ComputeFactorial(10));
    }
}