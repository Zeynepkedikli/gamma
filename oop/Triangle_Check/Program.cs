using System;

class TriangleCheck
{
    static void Main()
    {
        Console.WriteLine("Enter first side:");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second side:");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter third side:");
        int z = Convert.ToInt32(Console.ReadLine());

        if (x + y > z && y + z > x && z + x > y)
        {
            Console.Write("This is a valid triangle");

            if (x * x + y * y == z * z || z * z + y * y == x * x || x * x + z * z == y * y)
            {
                Console.Write(" and it's a right triangle");
            }
        }
        else
        {
            Console.WriteLine("This is not a valid triangle");
        }
    }
}