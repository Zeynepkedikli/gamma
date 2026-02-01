using System;
using System.Collections.Generic;

namespace CompanyApp
{
    public class Employee
    {
        private string name;
        private string position;
        private double salary;
        private int age;
        private bool boss;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public bool Boss
        {
            get { return boss; }
            set { boss = value; }
        }

        static int GenerateAge()
        {
            Random random = new Random();
            return random.Next(18, 60);
        }

        public Employee(string pname, string pposition, double psalary)
        {
            name = pname;
            position = pposition;
            salary = psalary;
            age = GenerateAge();
            boss = false;
        }

        public virtual void GiveRaise(double percent)
        {
            salary = Salary * (1.0 + percent / 100.0);
        }

        public static void PrintEmployees(List<Employee> employees)
        {
            foreach (Employee emp in employees)
            {
                string type = emp.GetType().ToString();
                int pos = type.IndexOf('.');
                type = type.Substring(pos + 1, 5);
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", emp.Name, emp.Position, Math.Round(emp.Salary, 2), emp.Age, type);
            }
        }
    }

    public class Manager : Employee
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Manager(string pname, string pposition, double psalary, string ptitle) : base(pname, pposition, psalary)
        {
            Boss = true;
            Title = ptitle;
        }

        public override void GiveRaise(double percent)
        {
            Salary = Salary * (1.0 + percent / 100.0);
            Salary += 2000;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee("John Smith", "IT Engineer", 15000));
            employees.Add(new Employee("Robert Brown", "Military", 80000));
            employees.Add(new Employee("Emily White", "Doctor  ", 50000));
            employees.Add(new Employee("Michael Green", "Teacher  ", 20000));
            employees.Add(new Employee("Sarah Black", "Designer", 30000));

            Manager manager = new Manager("James Gray", "Designer", 80000, "Director");
            employees.Add(manager);

            Console.WriteLine("\n\n-------------The list of employees------------\n");
            Employee.PrintEmployees(employees);

            foreach (Employee emp in employees)
            {
                emp.GiveRaise(20);
            }

            Console.WriteLine("\n--------------After a 20% rise--------------\n");
            Employee.PrintEmployees(employees);

            Console.WriteLine("\n--------------Info about Manager--------------\n");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", manager.Name, manager.Position, Math.Round(manager.Salary, 2), manager.Age, manager.Title);
        }
    }
}