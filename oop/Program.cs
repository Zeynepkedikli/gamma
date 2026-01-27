using System;
using System.Collections.Generic;
using System.Linq;
// base class, name, cost, how much() return
class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual double HowMuch()
    {
        return 0;
    }
}
//breed(cat or dog) for dog main cost+walk cost
class Species : Animal
{
    public string Breed { get; set; }

    
    private const double CatCost = 1500;
    private const double DogCost = 3000;
    private const double DogWalkCost = 500;

    public Species(string name, int age, string breed)
        : base(name, age)
    {
        Breed = breed;
    }

    public override double HowMuch()
    {
        if (Breed == "Cat")
            return CatCost;

        else if (Breed == "Dog")
            return DogCost + DogWalkCost;

        return 0;
    }

    
    public double WalkCost()
    {
        if (Breed == "Dog")
            return DogWalkCost;

        return 0;
    }
}

class Program
{
    static void Main()
    {
        List<Animal> Animals = new List<Animal>
        {
            new Species("Mia", 2, "Cat"),
            new Species("Luna", 3, "Cat"),
            new Species("Max", 4, "Dog"),
            new Species("Rocky", 5, "Dog")
        };

        Console.WriteLine("ANIMALS\n");

        foreach (Animal animal in Animals)
        {
            Species s = (Species)animal;

            Console.WriteLine($"Name: {s.Name}");
            Console.WriteLine($"Breed: {s.Breed}");
            Console.WriteLine($"Total Cost: {s.HowMuch()}");

            if (s.Breed == "Dog")
            {
                Console.WriteLine($"Walk Cost: {s.WalkCost()}");
            }

            Console.WriteLine("---------------------");
        }

        // the average price for the cats and dogs with LİNQ methods
        double AverageCatPrice = Animals
            .Cast<Species>()
            .Where(a => a.Breed == "Cat")
            .Average(a => a.HowMuch());

        double AverageDogPrice = Animals
            .Cast<Species>()
            .Where(a => a.Breed == "Dog")
            .Average(a => a.HowMuch());

        Console.WriteLine("AVERAGES");
        Console.WriteLine("Average Cat Price: " + AverageCatPrice);
        Console.WriteLine("Average Dog Price: " + AverageDogPrice);

        Console.ReadLine();
    }
}
