using _3_LiskovSubstitutionPrincipleLibraryFIXED;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LiskovSubstitutionPrincipleFIXED
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager accountingVP = new Manager();

            accountingVP.FirstName = "Peter";
            accountingVP.FirstName = "Parker";
            accountingVP.CalculateHourRate(4);

            Employee emp = new Manager(); 



            emp.FirstName = "Bruce";
            emp.LastName = "Wayne";
            emp.AssignManager(accountingVP);
            emp.CalculateHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");

            Console.ReadLine();
        }
    }
}
