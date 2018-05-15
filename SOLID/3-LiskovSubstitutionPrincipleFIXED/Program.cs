using _3_LiskovSubstitutionPrincipleLibraryFIXED;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LiskovSubstitutionPrincipleFIXED
{
    /// <summary>
    /// HOW TO FIX THE PROBLEM AND CREATE A GOOD INHERITANCE STRUCTURE
    /// 
    /// Find out what the derived classes have in common with the base class
    /// FirstName - LastName - Salary - CalculatePerHourRate
    /// 
    /// Find out what isnt in common
    /// 1- public Employee Manager { get; set; } 
    /// 2-AssignManager(); (this is not ok as this works "differently" in CEO, throws exception and doesnt assign manager)  
    /// 3-GeneratePerformanceReviews (is ok becuase it is an extra method not in employee)
    /// 
    /// Create interface from Employee Base class with only fields and methods in common
    /// Make sure Employee Base class now implements the IEmployee interface
    /// Create IManager interface and have it implement the IEMployee inyterface - a manager is an employee
    /// A manager though has access to another method called GeneratePErformanceReview - add this mthod to IManager
    /// so the IManager interface has eveything IEmployee does plus GeneratePerformanceReview
    /// Create IManaged interface and have it implement IEmployee
    /// Add the mehtods and fields needed by someone who is managed to the interface:
    ///  public virtual void AssignManager(Employee manager) this needs Employee Manager { get; set; }  
    /// 
    /// So instead of Manager inherting from Employee - we can now have Manager implement the IManager interface
    /// problem is that we now need to implement all the code from the interafce in the Manager class so to get round this
    /// we can crate anther class called BaseEmployee - have this implement the IEmployee interface
    /// now we can change the Employee to inherit from the BaseEmployee and only have the Employee Manager field and AssignManager method in it
    /// An employee is managed so we have Employee implement the IMAnaged interface as well
    ///
    /// Manager class inherits from Employee and this is ok becuase everything in Employee is OK for Manager
    /// but a manager manages so we need to add IManager interface to Manager class
    /// 
    /// CEO however is not an employee (doesnt pass the IS A test) so we remove Employee from CEO so it doesnt inherit anymore
    /// and add BaseEmployee class to inherit from and IManager interface instead
    /// 
    /// So now the CEO inherits from BaseEmployee that has fields and methods in common with everything 
    /// and the Employee class in now only used so the manager can inherit from it
    /// NOTE-BaseEmployee never needs to be instatiated should be abstract
    /// 
    /// SOLUTION:
    /// 
    /// So Employee and Manager have the same field and mehtods with manager inheriting from Employee - Manager has added GeneratePerformanceReview
    /// Employee inherits from BaseEmpoyee as does CEO - but not Manager as manager inherits from Employee which has the non common field and methods added to it
    /// Employee implements IManaged - but Manager implements IManager
    /// 
    /// CEO inherits from BaseEmployee (not Employee) as BaseEmployee has only common fields and methods
    /// CEO also implements IManager
    /// 
    /// 
    /// </summary>


    class Program
    {
        static void Main(string[] args)
        {
            Manager accountingVP = new Manager();

            accountingVP.FirstName = "Peter";
            accountingVP.FirstName = "Parker";
            accountingVP.CalculateHourRate(4);

            Employee emp = new Employee(); 



            emp.FirstName = "Bruce";
            emp.LastName = "Wayne";
            emp.AssignManager(accountingVP);
            emp.CalculateHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");

            Console.ReadLine();
        }
    }
}
