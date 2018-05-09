using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            //The messages go in the messages class
            //DataCapture goes in the data cature class
            //Validation goes in the PersonValidator class
            //Account generation has a message but it is about the account generation so not all messages go in the messages class
            //The Program class on controls the flow of the application

            //if I want to change what happens at the at a certain point I only need to change one aspect of the code now
            //e.g  if I add this to StandardMessages.EndApplication - Console.WriteLine("Press enter to close"); - everywhere it is called this change happens
             
            //You could also split the StandaMessages class into WelcomeMessage class EndApplicationMessage class and this would be ok - but dont go crazy 
            //thousand of classes that have one line of code will cause bloat

            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture(); //Newing up a class here means this is tightly coupled - a later design principle covers this

            bool isUserValid = PersonValidator.Validate(user);

            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.CreateAccount(user);

            StandardMessages.EndApplication();

        }
    }
}
