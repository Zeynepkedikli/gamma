using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    private static int Counter = 0;
    private static double TotalGrade = 0;

    public string Name;
    public string Faculty;
    public double Grade;

    public Student(string name, string faculty, double grade)
    {
        if (grade < 0 || grade > 100)
            throw new ArgumentException("Not 0-100 arasında olmalıdır.");

        Counter++;
        TotalGrade += grade;

        Name = name;
        Faculty = faculty;
        Grade = grade;
    }

    public static int GetObjectCount() => Counter;

    public static double GetAverageGrade() => Math.Round(TotalGrade / Counter, MidpointRounding.AwayFromZero);

    public void DisplayInfo() => Console.WriteLine($"Ad: {Name}, Fakülte: {Faculty}, Not: {Grade:0.00}");
}

class Program
{
    static void Main()
    {
        var students = new List<Student>();
        var rnd = new Random();

        students.Add(new Student("Zeynep", "Computer Engineering", Math.Round(rnd.NextDouble() * 100, 2)));
        students.Add(new Student("Kemal", "Makine Mühendisliği", Math.Round(rnd.NextDouble() * 100, 2)));
        students.Add(new Student("Selen", "Bağcık Mühendisliği", Math.Round(rnd.NextDouble() * 100, 2)));
        students.Add(new Student("Alperen", "Endüstri Mühendisliği", Math.Round(rnd.NextDouble() * 100, 2)));
        students.Add(new Student("Batuhan", "Yazılım Mühendisliği", Math.Round(rnd.NextDouble() * 100, 2)));

        // 1️⃣ İsme göre sıralama
        var sortedByName = students.OrderBy(s => s.Name).ToList();
        Console.WriteLine("---- Students Sorted by Name ----");
        foreach (var s in sortedByName)
        {
            s.DisplayInfo();
        }

        // 2️⃣ Nota göre sıralama
        var sortedByGrade = students.OrderByDescending(s => s.Grade).ToList();
        Console.WriteLine("\n---- Students Sorted by Grade ----");
        foreach (var s in sortedByGrade)
        {
            s.DisplayInfo();
        }

        Console.WriteLine($"\nCreated student count: {Student.GetObjectCount()}");
        Console.WriteLine($"Average grade: {Student.GetAverageGrade()}");

        // En iyi öğrenci
        var best = sortedByGrade.First();
        var bestGradeRounded = Math.Round(best.Grade, MidpointRounding.AwayFromZero);
        Console.WriteLine($"\nThe Best Student: {best.Name} - Grade: {bestGradeRounded}");

        Console.ReadLine();
    }
}
