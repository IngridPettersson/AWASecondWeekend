using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesLambda
{
    class EmployeeLambda
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<EmployeeLambda> empList, IsPromotable delIsPromotable)
        {
            foreach (EmployeeLambda employee in empList)
            {
            if (delIsPromotable(employee))
                    Console.WriteLine($"{employee.Name} promoted");

            }
        }
    }
}
