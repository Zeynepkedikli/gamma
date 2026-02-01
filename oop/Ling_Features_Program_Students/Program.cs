using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>() {
                new Student() { University = "MIT", Name = "Alice", Grade = 88, Major = "Computer Science"} ,
                new Student() { University = "MIT", Name = "Bob", Grade = 75, Major = "Computer Science"} ,
                new Student() { University = "Harvard", Name = "Charlie", Grade = 92, Major = "Engineering" } ,
                new Student() { University = "MIT", Name = "Diana", Grade = 68, Major = "Computer Science" } ,
                new Student() { University = "Harvard", Name = "Eve", Grade = 55, Major = "Engineering"} ,
                new Student() { University = "MIT", Name = "Frank", Grade = 82, Major = "Computer Science" },
                new Student() { University = "MIT", Name = "George", Grade = 79, Major = "Business" },
                new Student() { University = "MIT", Name = "Helen", Grade = 71, Major = "Engineering" },
                new Student() { University = "Harvard", Name = "Ivan", Grade = 95, Major = "Business" },
                new Student() { University = "Stanford", Name = "Julia", Grade = 85, Major = "Engineering" },
                new Student() { University = "Stanford", Name = "Kevin", Grade = 98, Major = "Computer Science" },
                new Student() { University = "MIT", Name = "Laura", Grade = 66, Major = "Art" }
            };


        Console.WriteLine("========================================");
        Console.WriteLine("Example 1: Filtering and Grouping");
        Console.WriteLine("========================================");

        // WHERE + ORDERBY + GROUP BY
        var query1 = from stud in students
                     where stud.Grade > 70
                     orderby stud.University, stud.Grade descending
                     group stud by stud.University;

        foreach (var university in query1)
        {
            Console.WriteLine("");
            Console.WriteLine("University: {0}", university.Key);

            foreach (Student s in university)
                Console.WriteLine("  {0} \t  Major: {1} \t\t Grade: {2}", s.Name, s.Major, s.Grade);
        }


        Console.WriteLine("");
        Console.WriteLine("========================================");
        Console.WriteLine("Example 2: Average with WHERE filter");
        Console.WriteLine("========================================");

        // WHERE + GROUP BY + INTO + SELECT NEW + AVERAGE
        var query2 =
            from stud in students
            where stud.Grade >= 60
            group stud by stud.University into uniGroup
            select new
            {
                UniversityName = uniGroup.Key,
                AvgGrade = uniGroup.Average(s => s.Grade),
                StudentCount = uniGroup.Count()
            };

        foreach (var item in query2)
        {
            Console.WriteLine("{0} \t Avg: {1:F2} \t Count: {2}",
                item.UniversityName, item.AvgGrade, item.StudentCount);
        }


        Console.WriteLine("");
        Console.WriteLine("========================================");
        Console.WriteLine("Example 3: Major analysis with filtering");
        Console.WriteLine("========================================");

        // WHERE + ORDERBY DESCENDING + GROUP BY + INTO + SELECT NEW + AVERAGE
        var query3 =
            from stud in students
            where stud.Major != "Art"
            orderby stud.Major descending
            group stud by stud.Major into majorGroup
            select new
            {
                MajorName = majorGroup.Key,
                AvgGrade = majorGroup.Average(s => s.Grade),
                MaxGrade = majorGroup.Max(s => s.Grade),
                MinGrade = majorGroup.Min(s => s.Grade)
            };

        foreach (var item in query3)
        {
            Console.WriteLine("{0} \t Avg: {1:F2} \t Max: {2} \t Min: {3}",
                item.MajorName, item.AvgGrade, item.MaxGrade, item.MinGrade);
        }

        Console.WriteLine("");
        Console.WriteLine("========================================");
        Console.WriteLine("Example 4: Top performing universities");
        Console.WriteLine("========================================");

        // WHERE + GROUP BY + INTO + SELECT NEW + AVERAGE + ORDERBY DESCENDING
        var query4 =
            from stud in students
            where stud.Grade > 65
            group stud by stud.University into uniGroup
            orderby uniGroup.Average(s => s.Grade) descending
            select new
            {
                University = uniGroup.Key,
                AverageScore = uniGroup.Average(s => s.Grade),
                TotalStudents = uniGroup.Count()
            };

        foreach (var item in query4)
        {
            Console.WriteLine("{0} \t Avg: {1:F2} \t Students: {2}",
                item.University, item.AverageScore, item.TotalStudents);
        }

    }
}

public class Student
{
    public string University { get; set; }
    public string Name { get; set; }
    public int Grade { get; set; }
    public string Major { get; set; }
}