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
                new Employee {ID = 100, Name = "Madame", Salary = 5000, Experience = 5},
                new Employee {ID = 101, Name = "Baba", Salary = 4000, Experience = 4},
                new Employee {ID = 102, Name = "Strumpan", Salary = 6000, Experience = 6},
                new Employee {ID = 103, Name = "Troj", Salary = 3000, Experience = 3}
            };

            // The instance of the delegate, which points to the methode Promote(), is created here in the Main method in the Program class.
            // The method Promote() must also take an Employee as the argument, and return a bool type, just like the delegate IsPromotable (see
            // below).
            IsPromotable delIsPromotable = new IsPromotable(Promote);

            // Calling the method PromoteEmployee() in the Employee class, with our list of employees, empList, and our instance of the delegate
            // IsPromotable, delIsPromotable, as the arguments passed in.
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

    // The signature of the delegate is defined in the namespace, outside of any other class, just like a class itsel or an interface.
    // Should probably be put in its own file. It takes an Employee as parameter and has a bool return type.
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
