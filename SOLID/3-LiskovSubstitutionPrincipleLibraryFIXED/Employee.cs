using System;
using System.Collections.Generic;
using System.Text;

namespace _3_LiskovSubstitutionPrincipleLibraryFIXED
{
    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; } = null;

        public virtual void AssignManager(Employee manager)
        {
            //Simulates doing other tasks here - otherwise, this should be
            //a property set statement, not a method.
            Manager = manager;
        }

    }
}
