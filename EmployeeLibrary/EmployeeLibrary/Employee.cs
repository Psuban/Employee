using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    [Serializable]
    public class Employee
    {
        string employeeID;
        string employeeName;
        string employeeAddress;
        public Posts Posts{ get; set; }

        public string ID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        public string Name
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public string Address
        {
            get { return employeeAddress; }
            set { employeeAddress = value; }
        }

        public virtual double CalcWeeklyPay()
        {
            return 0;
        }

        public Employee(string id, string name, string address)
        {
            employeeID = id;
            employeeName = name;
            employeeAddress = address;
            Posts = new Posts();
        }

        public Employee()
        {
            Posts = new Posts();
        }

        public override string ToString()
        {
            return "ID: " + employeeID + "\nName: " + employeeName + "\nAddress: " + employeeAddress + "\nWeekly Pay: " + Convert.ToString(CalcWeeklyPay());
        }

        ~Employee()
        {
            Console.WriteLine("Employee Destroyed");
        }
    }
}
