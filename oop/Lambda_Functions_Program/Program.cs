using System;
using System.Collections.Generic;

public class Program
{
    delegate string CheckEligibility(Student s, int minScore, int maxScore);

    public static void Main()
    {
        // Lambda expression with three parameters and ternary operator
        CheckEligibility isEligible = (student, min, max) =>
            (student.Marks > min && student.Marks < max)
            ? student.Name + " is eligible for " + student.faculty
            : student.Name + " is not eligible for " + student.faculty;

        Student s1 = new Student();
        s1.Name = "Jose";
        s1.Marks = 7;
        s1.faculty = "CS";

        Student s2 = new Student();
        s2.Name = "Ala";
        s2.Marks = 8;
        s2.faculty = "Philology";

        Student s3 = new Student();
        s3.Name = "Franc";
        s3.Marks = 9;
        s3.faculty = "Philology";

        Student s4 = new Student();
        s4.Name = "Ola";
        s4.Marks = 13;
        s4.faculty = "Philology";

        List<Student> studentList = new List<Student>();

        studentList.Add(s1);
        studentList.Add(s2);
        studentList.Add(s3);
        studentList.Add(s4);

        // Call lambda through delegate for each student
        for (int i = 0; i < studentList.Count; i++)
        {
            string result = isEligible(studentList[i], 9, 14);
            Console.WriteLine(result);
        }
    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
    public string faculty { get; set; }
}