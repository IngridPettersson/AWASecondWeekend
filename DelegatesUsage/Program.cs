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
        }
    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }


        public void PromoteEmployee(List<Employee> employeeList)
        {
            foreach (Employee employee in employeeList)
            {
                if (employee.Experience >= 5)
                    Console.WriteLine($"{employee.Name} promoted");

            }
        }
    }
}
