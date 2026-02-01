using System;
using System.Collections.Generic;

namespace CompanyApp
{
    class EmployeeTest
    {
        static void Main()
        {
            Console.WriteLine("=== Employee Test ===");
            Employee emp = new Employee("Tom Wilson", "Engineer", 25000);
            Console.WriteLine("{0}: {1}", emp.Name, emp.Salary);

            emp.GiveRaise(10);
            Console.WriteLine("After raise: {0}", emp.Salary);

            Console.WriteLine("\n=== Manager Test ===");
            Manager mgr = new Manager("Lisa Brown", "Operations", 50000, "VP");
            mgr.GiveRaise(10);
            Console.WriteLine("{0} ({1}): {2}", mgr.Name, mgr.Title, mgr.Salary);
        }
    }
}