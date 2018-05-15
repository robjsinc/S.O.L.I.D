using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LiskovSubstitutionPrincipleLibraryFIXED
{
    interface IManaged : IEmployee
    {
        IEmployee Manager { get; set; }

        void AssignManager(Employee manager);

    }
}
