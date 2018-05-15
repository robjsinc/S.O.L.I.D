using _2_OpenClosedPrincipleLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OpenClosedPrinciple
{
    class Program
    {
        //Open Closed Principle - OCP
        //https://www.youtube.com/watch?v=VFlk43QGEgc

        //This examples takes applicants and creates employees then makes an employee list using interfaces.
            
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

            we change it again - take out the if stattement and add a switch - this adds bugs to the program - we have taken code we rely on - changed it and broke it
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


                Once a program has gone live you should not change the code the application relies on. For instance you should not change a function. 
                You can make minor changes such as adding field as these wont break the program, but it you dont have to you shouldnt. 

                Example Setup - change 3 different applicants to EmployeeModel list:

                Three types of Applicants all implement the IAccounts interface:
                PersonModel - ExecutiveModel and ManagerModel
                The interface has variables, but also another interface to CreateAccount(); in it. Each is different depending on what account needs to be created e.g:
                public IAccounts CreateAccount { get; set; } = new ManagerAccount();

                ManagerAccount is one type of account - three types of Accounts can be created all implement the IAccounts interface:
                PersonAccount - ExecutiveAccount and ManagerAccount
                The interface has a function to Create(); in the classes this Create(); is different depoending on what account is required but all Create(); 
                functions return the EmployeeModel


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
