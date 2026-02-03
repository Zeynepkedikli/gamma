using System;
using System.Collections.Generic;
using System.Linq;


class Figure
{
    private int Dimension;// here ı did encapsulation about private field

    public Figure(int dimension)
    {
        Dimension = dimension;
    }

    public int GetDimension
    {
        get { return Dimension; }
        set { Dimension = value; }
    }

    //  virtual metot for the polimorphism
    public virtual int GetArea()
    {
        return 0;  // for rectangle that have not area,( like line etc)
    }
}
// ınheritance: rectangle class create from figure class.
class Rectangle : Figure
{
    private int Width;
    private int Length;

    public Rectangle(int width, int length) : base(2) //constructor use
    {
        Width = width;
        Length = length;
    }

    public int GetWidth
    {
        get { return Width; }
        set { Width = value; }
    }

    public int GetLength
    {
        get { return Length; }
        set { Length = value; }
    }

    public override int GetArea() // override get area. this is for polymorphism.
    {
        return Width * Length;
    }
}

class Program
{
    static void Main()
    {
        List<Rectangle> Rectangles = new List<Rectangle>
        {
            new Rectangle(0, 4),
            new Rectangle(3, 4),
            new Rectangle(5, 8),
            new Rectangle(9, 3),
            new Rectangle(10, 8)
        };

        Console.WriteLine("Rectangle Sizes and Areas:\n");

        foreach (Rectangle R in Rectangles)
        {
            Console.WriteLine(
                $"Width: {R.GetWidth}, Length: {R.GetLength}, Area: {R.GetArea()}"
            );
        }

        // calculate average area with using LINQ 
        double AverageArea = Rectangles.Average(R => R.GetArea());

        Console.WriteLine($"\nAverage Area: {AverageArea}");
    }
}
