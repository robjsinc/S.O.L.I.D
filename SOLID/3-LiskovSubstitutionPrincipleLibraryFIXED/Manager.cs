using System;
using System.Collections.Generic;
using System.Text;

namespace _3_LiskovSubstitutionPrincipleLibraryFIXED
{
    public class Manager : Employee, IManager
    {
        public override void CalculateHourRate(int rank)
        {
            decimal baseAmount = 19.75M;
             
            Salary = baseAmount + (rank * 4);            
        }

        public void GeneratePerformanceReview()
        {
            //Simulate reviewing a direct report
            Console.WriteLine("Im reviewing a direct reports perfromance.");
        }
    }
}
