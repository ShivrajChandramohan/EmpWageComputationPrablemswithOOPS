using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonStaticEmpWageProblem
{
    public class EmpAttendence
    {
        public void EmployeeCheck()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(2);

            if (empCheck == IS_FULL_TIME)

            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}