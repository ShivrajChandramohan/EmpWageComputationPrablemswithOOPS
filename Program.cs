using static EmpWageComputationProblemWithOOP.EmpWage;

namespace EmpWageComputationProblemWithOOP
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<EmpWage> companies = new List<EmpWage>();

            Console.WriteLine("Welcome to Employee Wage Computation Program On Master Branch");
            Console.WriteLine("----------------------------------------------------------------------");

            while (true)
            {
                Console.WriteLine("******************:MENU:******************");
                Console.WriteLine("PRESS 1: To Calculate the wage in a Company.");
                Console.WriteLine("PRESS 2: To EXIT.");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter the details:");
                    companies.Add(new EmpWage());
                    Console.WriteLine("_________________________________________________");
                   
                }
                else if (choice == 2)
                {
                    break;
                }
            }



        }
    }
}