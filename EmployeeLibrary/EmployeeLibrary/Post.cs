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

        public string ID
        {
            get { return postID; }
            set { postID = value; }
        }

        public string Name
        {
            get { return postName; }
            set { postName = value; }
        }
        public DateTime StartDate
        {
            get { return postStartDate; }
            set { postStartDate = value; }
        }

        public DateTime EndDate
        {
            get { return postEndDate; }
            set { postEndDate = value; }
        }

        public double Salary
        {
            get { return postSalary; }
            set { postSalary = value; }
        }

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

        public string ToString()
        {
            return "\nID:" + postID + "\nName: " + postName + "\nStart Date: " + Convert.ToString(postStartDate) + "\nEnd Date: " + Convert.ToString(postEndDate) + "\nSalary: " + postSalary;
        }
    }
}
