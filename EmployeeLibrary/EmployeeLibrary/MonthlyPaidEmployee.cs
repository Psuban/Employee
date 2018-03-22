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
            double totalSalary = 0;
            int numberOfSalaries = monthlyPaidEmployeePostHistory.Count;

            foreach (Post post in monthlyPaidEmployeePostHistory)
                {
                    totalSalary = totalSalary + post.Salary;
                }

            return totalSalary / numberOfSalaries;
        }

        public override double CalcWeeklyPay()
        {
            return monthlyPaidEmployeeAnnualSalary / 2;
        }

        public override string ToString()
        {
            return base.ToString() + "\nAnnual Salary: " + monthlyPaidEmployeeAnnualSalary;
        }
    }
}
