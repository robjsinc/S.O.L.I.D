using System;

namespace _3_LiskovSubstitutionPrincipleLibraryFIXED
{
    public class CEO : BaseEmployee, IManager
    {
        public override void CalculateHourRate(int rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount + (rank);

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
