using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    [Serializable]
    class WeeklyPaidEmployee:Employee
    {
        public double WeeklyPaidEmployeeWeeklyWages { get; set; }

        public Posts WeeklyPaidEmployeePostHistory { get; set; }

        public double CalcSalaryAverage()
        {
            double totalSalary = 0;
            int numberOfPosts = WeeklyPaidEmployeePostHistory.Count;
                foreach (Post post in WeeklyPaidEmployeePostHistory)
                    {
                        totalSalary += post.Salary;
                    }
            return totalSalary / numberOfPosts;
        }

        public override double CalcWeeklyPay()
        {
            return WeeklyPaidEmployeeWeeklyWages;
        }

        public override string ToString()
        {
            return base.ToString() + "\nWeekly Wage: " + WeeklyPaidEmployeeWeeklyWages;
        }
    }
}
