using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    [Serializable]
    public sealed class TemporaryHourlyPaidEmployee : HourlyPaidEmployee
    {
        public DateTime TemporaryHourlyPaidEmployeeStart { get; set; }
        public DateTime TemporaryHourlyPaidEmployeeEnd { get; set; }

        public TemporaryHourlyPaidEmployee(string id, string name, string address, DateTime start, DateTime end, double hourlyRate, int hours )
            :base (id,name,address,hourlyRate,hours)
        {
            TemporaryHourlyPaidEmployeeStart = start;
            TemporaryHourlyPaidEmployeeEnd = end;
        }

        public override string ToString()
        {
            return base.ToString() + "\nTemp Start: " + TemporaryHourlyPaidEmployeeStart.ToString() + "\nTemp End: " + TemporaryHourlyPaidEmployeeEnd.ToString();
        }
    }
}
