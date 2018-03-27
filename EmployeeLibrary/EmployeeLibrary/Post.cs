    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    [Serializable]
    public class Post
    {
        string postID;
        string postName;
        DateTime postStartDate;
        DateTime postEndDate;
        double postSalary;

        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Salary { get; set; }
        public Post (string id, string name, DateTime startDate, DateTime endDate, double salary)
        {
            postID = id;
            postName = name;
            postStartDate = startDate;
            postEndDate = endDate;
            postSalary = salary;
        }

        public Post()
        {

        }

        public override string ToString()
        {
            return "\nID:" + postID + "\nName: " + postName + "\nStart Date: " + Convert.ToString(postStartDate) + "\nEnd Date: " + Convert.ToString(postEndDate) + "\nSalary: " + postSalary;
        }
    }
}
