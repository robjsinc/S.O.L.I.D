namespace _3_LiskovSubstitutionPrincipleLibraryFIXED
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }

        void CalculateHourRate(int rank);
    }
}