using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputationProblemWithOOP
{
    public class SaveTotalWageForEachCompony
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private string compony;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public SaveTotalWageForEachCompony(string compony, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.compony = compony;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;

        }

        public void computeEmpWage()
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day# :" + totalWorkingDays + "Emp hours: " + totalEmpHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total emp wage for compony: " + compony + " is :" + totalEmpWage);
        }
        public string toString()
        {
            return "Total Emp Wage for compony : " + this.compony + " is: " + this.totalEmpWage;
        }
    }
}
Footer
© 2023 GitHub, Inc.
Footer navigation
Terms
Privacy
Secur