using System;

class FibonacciNumbers
{
    static int GetFib(int num)
    {
        if (num <= 2)
            return 1;

        int first = 1;
        int second = 1;
        int result = 0;

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
        for (int k = 1; k < 25; k++)
        {
            Console.Write(GetFib(k) + " ");
        }
        Console.WriteLine();
    }
}