using System;
using System.Collections.Generic;

namespace DelegatesUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee {ID = 101, Name = "Madame", Salary = 5000, Experience = 5},
                new Employee {ID = 101, Name = "Baba", Salary = 4000, Experience = 4},
                new Employee {ID = 101, Name = "Strumpan", Salary = 6000, Experience = 6},
                new Employee {ID = 101, Name = "Troj", Salary = 3000, Experience = 3}
            };

            IsPromotable delIsPromotable = new IsPromotable(Promote);

            Employee.PromoteEmployee(empList, delIsPromotable);
        }

        public static bool Promote(Employee emp)
        {
            if (emp.Experience >= 5)
                return true;
            else
                return false;
        }
    }

    // If we want this Employee-class to be reusable we cannot have any non-dynamic logic put in to it. An employer might want to promote their employee based on salary + experience, 
    // or only experience or only salary and what not. That is where the usage of delegates come in.

    delegate bool IsPromotable(Employee empl);
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }


        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
        {
            foreach (Employee employee in employeeList)
            {
                if (IsEligibleToPromote(employee))
                    Console.WriteLine($"{employee.Name} promoted");

            }
        }
    }
}
