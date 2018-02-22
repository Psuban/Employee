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
        double employeeSalary;
        Posts posts;

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
        public double Salary
        {
            get { return employeeSalary; }
            set {employeeSalary = value; }
        }

        public Posts Posts
        {
            get { return posts; }
            set { posts = value; }
        }

        public double CalcWeeklyPay()
        {
            return Salary / 52;
        }

        public Employee(string id, string name, string address, double salary)
        {
            employeeID = id;
            employeeName = name;
            employeeAddress = address;
            employeeSalary = salary;
            posts = new Posts();
        }

        public Employee()
        {
            posts = new Posts();
        }

        public string ToString()
        {
            return "ID: " + employeeID + "\nName: " + employeeName + "\nAddress: " + employeeAddress + "\nSalary: " + employeeSalary + "\nWeekly Pay: " + Convert.ToString(CalcWeeklyPay());
        }

        ~Employee()
        {
            Console.WriteLine("Employee Destroyed");
        }
    }
}
