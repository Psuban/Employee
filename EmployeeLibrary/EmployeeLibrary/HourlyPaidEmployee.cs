using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    [Serializable]
    public class HourlyPaidEmployee:Employee
    {
        public double HourlyPaidEmployeeRate { get; set; }
        public int HourlyPaidEmployeeHours { get; set; }

        public override double CalcWeeklyPay()
        {
            return HourlyPaidEmployeeHours * HourlyPaidEmployeeRate;
        }

        public HourlyPaidEmployee ( string id, string name, string address, double hourlyPaidRate, int hourlyPaidHours)
            :base(id,name,address)
        {
            HourlyPaidEmployeeRate = hourlyPaidRate;
            HourlyPaidEmployeeHours = hourlyPaidHours;
        }

        public override string ToString()
        {
            return base.ToString() + "\nHourly Rate: " + Math.Round(HourlyPaidEmployeeRate, 2) + "\nHours worked: " + HourlyPaidEmployeeHours;
        }
    }
}
