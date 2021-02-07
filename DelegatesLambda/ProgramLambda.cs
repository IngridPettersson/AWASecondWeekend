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



            // Calling the method in the Employee class, and here you can pass in the second argument as an instance of the 
            // delegate as a LAMBDA EXPRESSION. Whatever is put in as the here is going to operate on an instance of the Employee class an will return a bool.
            // Look at the signature of the PromoteEmployee() method in the EmployeeLambda class. It takes an instance of a List<EmployeeLambda> 
            // as the first parameter and an instance of the delegate IsPromotable as the second parameter.
            EmployeeLambda.PromoteEmployee(empList, emp => emp.Experience >= 5);
            

        }

    }

    delegate bool IsPromotable(EmployeeLambda employee);
}
