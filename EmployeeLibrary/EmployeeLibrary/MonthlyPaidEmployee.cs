using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    [Serializable]
    public sealed class MonthlyPaidEmployee:Employee
    {
        public double MonthlyPaidEmployeeAnnualSalary { get; set; }

        public Posts MonthlyPaidEmployeePostHistory { get; set; }

        public MonthlyPaidEmployee(string id, string name, string address, double annualSalary )
            :base(id,name,address)
        {
            MonthlyPaidEmployeeAnnualSalary = annualSalary;
            MonthlyPaidEmployeePostHistory = new Posts();
        }

        public double CalcSalaryAverage()
        {
            double totalSalary = 0;
            int numberOfSalaries = MonthlyPaidEmployeePostHistory.Count;

            foreach (Post post in MonthlyPaidEmployeePostHistory)
                {
                    totalSalary += post.Salary;
                }

            return totalSalary / numberOfSalaries;
        }

        public override double CalcWeeklyPay()
        {
            return MonthlyPaidEmployeeAnnualSalary / 52;
        }

        public override string ToString()
        {
            return base.ToString() + "\nAnnual Salary: " + MonthlyPaidEmployeeAnnualSalary;
        }
    }
}
