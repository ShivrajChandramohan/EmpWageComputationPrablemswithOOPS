using EmployeeWageComputationProblem;

namespace EmpWageComputationProblemWithOOP
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Problems with OOPS");
            EmpWageForMultipleComponies Companies = new EmpWageForMultipleComponies();
            Companies.computeEmpWage();

        }
    }
}
