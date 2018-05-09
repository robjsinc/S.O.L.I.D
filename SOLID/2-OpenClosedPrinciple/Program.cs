using OpenClosedPrincipleLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OpenClosedPrinciple
{
    class Program
    {
        //OCP - CLOSED for modification - OPEN for extension
        //OCP doesnt apply in the development process - once its in production the only reason you should change a class is if a bug is in it
        //BUT minor changes like this that dont effect the program - public bool IsManager { get; set; } = false;  are ok  
        //but if you dont want to do this can craete an interface instead
        //however adding the below to the Accounts.Create does break OCP
        /*            
            if (person.TypeOfEmployee == EmployeeType.manager)
            {
                output.IsManager = true;
            }
        
            as we have changed a class that was in production and working

            we change it again - take out the if stattement and add a switch - this adds bugs to the program - we have taken code we rely on - hcnaged it and broke it
            this is against the OCP
             
            switch (person.TypeOfEmployee)
            {
                case EmployeeType.staff: 
                    break;
                case EmployeeType.manager:
                    output.IsManager = true;  
                    break;
                case EmployeeType.executive:
                    output.IsManager = true;
                    output.IsExecutive = true;
                    break;
                default:
                    break;
            }

            Look at the List<IApplicants> and you will see because the list is an interface we can add any class to the list that implements the interface
            This allows us to EXTEND the code to add new features but not modify the code that has been working in the live app

        */

        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>()
            {
                new ExecutiveModel() {FirstName = "The", LastName = "Rock"},
                new ManagerModel() {FirstName = "Jake The", LastName = "Snake"},
                new PersonModel() {FirstName = "The Ultimate", LastName = "Warrior"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager = {emp.IsManager} IsExecutive = {emp.IsExecutive} ");
            }

            Console.ReadLine();
        }
    }
}
