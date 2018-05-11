using System;
using System.Collections.Generic;
using System.Text;

namespace _3_LiskovSubstitutionPrincipleLibraryFIXED
{
    public class Employee 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee Manager { get; set; }
        public decimal Salary { get; set; }

        public virtual void AssignManager(Employee manager)
        {
            //Simulates doing other tasks here - otherwise, this should be
            //a property set statement, not a method.
            Manager = manager;
        }

        public virtual void CalculateHourRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }

    }
}
