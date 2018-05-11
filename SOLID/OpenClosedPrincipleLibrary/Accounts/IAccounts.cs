using _2_OpenClosedPrincipleLibrary;

namespace OpenClosedPrincipleLibrary
{
    public interface IAccounts
    {
        EmployeeModel Create(IApplicantModel person);
    }
}