using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    [Serializable]
    class MonthlyPaidEmployee:Employee
    {
        double monthlyPaidEmployeeAnnualSalary;
        Posts monthlyPaidEmployeePostHistory;

        public double MonthlyPaidEmployeeAnnualSalary
        {
            get { return monthlyPaidEmployeeAnnualSalary;  }
            set { monthlyPaidEmployeeAnnualSalary = value; }
        }

        public Posts MonthlyPaidEmployeePostHistory
        {
            get { return monthlyPaidEmployeePostHistory; }
            set { monthlyPaidEmployeePostHistory = value; }
        }

        public double CalcSalaryAverage()
        {
            double averageSalary=0;
                foreach (Post post in monthlyPaidEmployeePostHistory)
                {
                    double totalSalary = 0;
                    int numberOfSalaries = monthlyPaidEmployeePostHistory.Count;
                    totalSalary = totalSalary + post.Salary;
                    averageSalary = totalSalary / numberOfSalaries;
                }
           return averageSalary;
        }
    }
}
