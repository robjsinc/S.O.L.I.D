using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LiskovSubstitutionPrincipleLibraryFIXED
{
    public interface IManager : IEmployee
    {
        void GeneratePerformanceReview();
    }
}
