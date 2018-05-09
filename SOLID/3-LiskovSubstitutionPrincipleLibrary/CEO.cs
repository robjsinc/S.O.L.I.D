using System;

namespace _3_LiskovSubstitutionPrincipleLibrary
{
    public class CEO : Employee
    {
        public override void CalculateHourRate(int rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount + (rank);

        }

        public override void AssignManager(Employee manager)
        {
            throw new InvalidOperationException("The CEO has no manager");
        }

        public void GeneratePerformanceReview()
        {
            //Simulate reviewing a direct report
            Console.WriteLine("Im reviewing a direct reports perfromance.");
        }

        public void FireSomeone()
        {
            //Simultae firing somone
            Console.WriteLine("Youre fired");
        }

    }
}
