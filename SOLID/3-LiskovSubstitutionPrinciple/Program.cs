using _3_LiskovSubstitutionPrincipleLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LiskovSubstitutionPrinciple
{
    class Program
    {
        /// <summary>
        /// 
        /// LSP - About how to create a good inheritance structure
        /// 
        /// To fix this problem watch video from about 20 minutes in
        /// Better to use interfaces if possible becuase of the limitations on Inheritance listed below
        /// 
        /// LSP Definition - if S is subtype of T - then object of type T may be replaced with object of type S without breaking the program  
        /// LSP says I should be able to chaneg Employee for Manager below becuase Manager is a subtype of Employee
        /// CEO is also a subtype of Employee but we cant change Empoyee to CEO - becuase the CEO doesnt have a manager!! - this is against LSP
        /// Classes that have inherited from another class/type should be able to replace the class/type without breaking the program
        /// 
        /// 
        /// 1 rule - the inherited class has to work in the same was as the base class.....
        /// 2 rule - dont throw new exception in inherited class that arent in the base class - this is why Employee cant be replaced with CEO
        /// 
        /// 
        ///  With inheritance its easy to get tripped up - "Is A" relationship test- a CEO "IS A" employee - not in C# becuase a CEO doesnt have a manager
        ///  if the class that needs to inherit "IS NOT A" of he base class - then cant use inheritance - Manager "IS A" Employee passes the test
        ///  
        ///  Also make sure to think if a method needs to be virtual when changing the class in the future  
        ///  as if it isnt marked as virtual and you need to change it later this will break the OpenClosed principle
        /// 
        /// </summary>



        static void Main(string[] args)
        {
            Manager accountingVP = new Manager();

            accountingVP.FirstName = "Peter";
            accountingVP.FirstName = "Parker";
            accountingVP.CalculateHourRate(4);

            Employee emp = new Employee(); /*HERE Manager(); works - CEO(); doesnt work*/
                                      
                                      

            emp.FirstName = "Bruce";
            emp.LastName = "Wayne";
            emp.AssignManager(accountingVP);
            emp.CalculateHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");

            Console.ReadLine();
        }
    }
}
