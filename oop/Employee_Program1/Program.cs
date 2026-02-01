using System;
namespace CompanyApp
{
    public class Employee
    {
        protected string Name { get; set; }
        protected string Position { get; set; }
        protected double Salary { get; set; }
        protected int Age { get; set; }
        public bool Boss { get; protected set; }

        protected static int GenerateAge()
        {
            Random random = new Random();
            return random.Next(18, 65);
        }

        protected Employee(string name, string pos, double sal, bool boss)
        {
            Name = name;
            Position = pos;
            Salary = sal;
            Age = GenerateAge();
            Boss = boss;
        }

        public void PrintInfo()
        {
            Console.WriteLine(
                "Name:{0}, Pos:{1}, Salary:{2}, Age:{3}, Boss:{4}",
                Name, Position, Salary, Age, Boss
            );
        }
    }

    class Employee1 : Employee
    {
        public Employee1() : base("John Smith", "IT Engineer", 15000, false) { }
    }

    class Employee2 : Employee
    {
        public Employee2() : base("Robert Brown", "Military", 80000, false) { }
    }

    class Employee3 : Employee
    {
        public Employee3() : base("Emily White", "Doctor", 50000, false) { }
    }

    class Employee4 : Employee
    {
        public Employee4() : base("Michael Green", "Teacher", 20000, false) { }
    }

    class Employee5 : Employee
    {
        public Employee5() : base("Sarah Black", "Designer", 30000, false) { }
    }

    class Manager1 : Employee
    {
        public Manager1() : base("James Gray", "Designer", 80000, true) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee1();
            Employee e2 = new Employee2();
            Employee e3 = new Employee3();
            Employee e4 = new Employee4();
            Employee e5 = new Employee5();
            Employee m1 = new Manager1();

            e1.PrintInfo();
            e2.PrintInfo();
            e3.PrintInfo();
            e4.PrintInfo();
            e5.PrintInfo();

            Console.WriteLine("\n        Up to the Employee Down to The Manager\n");

            m1.PrintInfo();
        }
    }
}