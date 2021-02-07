using System;
using System.Collections.Generic;

namespace DelegatesLambda
{
    class ProgramLambda
    {
        static void Main(string[] args)
        {
            List<EmployeeLambda> empList = new List<EmployeeLambda>
            {
                new EmployeeLambda {ID = 100, Name = "Strumpan", Salary = 6000, Experience = 5},
                new EmployeeLambda {ID = 101, Name = "Madame E Petit", Salary = 7000, Experience = 2},
                new EmployeeLambda {ID = 102, Name = "Min baba", Salary = 5000, Experience = 7},
                new EmployeeLambda {ID = 103, Name = "New Star", Salary = 4000, Experience = 0}
            };



            // Calling the method in the Employee class, and here you can pass in the second argument, which must be an instance of the 
            // delegate (see PromoteEmployee() method in EmployeeLambda class), as a LAMBDA EXPRESSION. Whatever is put in here is going to operate 
            // on an instance of the Employee class an will return a bool.
            // Look at the signature of the PromoteEmployee() method in the EmployeeLambda class. It takes an instance of a List<EmployeeLambda> 
            // as the first parameter and an instance of the delegate IsPromotable() as the second parameter.
            Console.WriteLine("Promoted based on experience:");
            EmployeeLambda.PromoteEmployee(empList, emp => emp.Experience >= 5);

            Console.WriteLine("\nPromoted based on salary:");
            // Here I reuse my EmployeeLambda class with another logic (condition), where the promotion is based on salary instead of experience
            EmployeeLambda.PromoteEmployee(empList, emp => emp.Salary > 5000);

            // And here promotion is based on name
            Console.WriteLine("\nPromoted based on name:");
            EmployeeLambda.PromoteEmployee(empList, emp => emp.Name[0] > 'M');

            Console.WriteLine("\nWorth noticing is that Strumpan gets promoted in all conditions! ;)");
            

        }

    }

    delegate bool IsPromotable(EmployeeLambda employee);
}
