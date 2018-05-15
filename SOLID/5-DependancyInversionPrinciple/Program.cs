using _5_DependencyInversionPrincipleLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_DependancyInversionPrinciple
{
    class Program
    {

        /// <summary>
        /// 
        /// DI states that high level modules should not depend on low level modules but rather both should depend on abstartions and those abstractions should not depend on details
        /// 
        /// High level module - anyhting that calls something else - static void main is high level as it calls into Person and Chore class, chore class is also high level
        /// Low level Module - EMailer,Logger,Person are low level Modules as they dont DEPEND on anything 
        /// 
        /// Create interfaces from classes and have the classes implement the interfaces
        /// Create a Factory clas in the conole application solution and create methods that new up the classes and return those newed up objects.
        /// 
        /// You can then instead of having this:
        ///  Person owner = new Person
        ///  {
        ///    FirstName = "Tim",
        ///  };
        /// 
        ///  you can have:
        ///  IPerson owner = new Factory.CreatePerson():
        ///  owner.FIrstName = "Tim";
        /// 
        /// This needs to be dobne for every new object that is in a higher level module - so to break the dependancies - in the program below the soltuion above is right
        /// But what 8if a class needs to new up an object - see Chore class for solution
        /// Create a constructor in Chore class - pass into the constructor the require interfaces - create interfaces in the class as fields and = the fields in 
        /// the constructor with the passed in interfaces - see the constructor in Chores for the example of this
        /// 
        /// 
        /// 
        /// 
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// 

    static void Main(string[] args)
        {
            Person owner = new Person
            {
                FirstName = "Tim",
                LastName = "Corey",
                EmailAddress = "tim@iamtimcorey.com",
                PhoneNumber = "555-1212"
            };

            Chore chore = new Chore
            {
                ChoreName = "Take out the trash",
                Owner = owner
            };

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
