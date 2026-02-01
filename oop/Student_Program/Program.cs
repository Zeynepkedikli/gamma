using System;
using System.Collections.Generic;

class Person
{
    public string Name;
    public string Field;
    public int Points;

    public Person(string n, string f, int p)
    {
        Name = n;
        Field = f;
        Points = p;
    }
}

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        List<Person> list = new List<Person>();

        list.Add(new Person("Michael Johnson", "Computer Science", rnd.Next(0, 101)));
        list.Add(new Person("Sarah Williams", "Law", rnd.Next(0, 101)));
        list.Add(new Person("David Miller", "Software Engineering", rnd.Next(0, 101)));
        list.Add(new Person("Emily Davis", "Foreign Languages", rnd.Next(0, 101)));
        list.Add(new Person("James Wilson", "Economics", rnd.Next(0, 101)));

        int total = 0;
        int max = 0;

        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("Name                      Field                     Points");
        Console.WriteLine("-------------------------------------------------------");

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine("{0,-25} {1,-25} {2}", list[i].Name, list[i].Field, list[i].Points);
            total = total + list[i].Points;
            if (list[i].Points > max)
                max = list[i].Points;
        }

        double avg = total / (double)list.Count;

        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("Total: " + list.Count);
        Console.WriteLine("Sum: " + total);
        Console.WriteLine("Average: " + avg);
        Console.WriteLine("Max: " + max);
        Console.WriteLine("-------------------------------------------------------");

        list.Sort((a, b) => a.Name.CompareTo(b.Name));

        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("Sorted by Name:");
        Console.WriteLine("-------------------------------------------------------");

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine("{0,-25} {1,-25} {2}", list[i].Name, list[i].Field, list[i].Points);
        }

        Console.WriteLine("-------------------------------------------------------");

        list.Sort((a, b) => b.Points.CompareTo(a.Points));

        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("Sorted by Points:");
        Console.WriteLine("-------------------------------------------------------");

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine("{0,-25} {1,-25} {2}", list[i].Name, list[i].Field, list[i].Points);
        }

        Console.WriteLine("-------------------------------------------------------");
    }
}