﻿using _2_OpenClosedPrincipleLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OpenClosedPrincipleLibrary
{
    class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            var output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName}.{person.LastName}@wwecorp.com";

            output.IsExecutive = true;
            output.IsManager = true;

            return output;
        }
    }
}
