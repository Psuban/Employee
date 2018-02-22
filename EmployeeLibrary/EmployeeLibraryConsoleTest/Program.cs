using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

namespace EmployeeLibraryConsoleTest
{
    class Program
    {
        static Employees employees = new Employees();
        static void Main(string[] args)
        {
            int userDecision=0;
            int separators = 40;
            while (userDecision!=20)
            {
                Console.WriteLine("EMPLOYEE LIBRARY TEST PROGRAM\n");

                Console.WriteLine("Please choose from one of the following options" +
                    "\n1. Add a new employee" +
                    "\n2. Add a new post" +
                    "\n3. Remove an employee" +
                    "\n4. Remove post" +
                    "\n5. Display an individual employee and their Post collection" +
                    "\n6. display all the employees in the collection (display of Posts optional)" +
                    "\n20. Exit\n");
                userDecision = Convert.ToInt32(Console.ReadLine());
                PrintConsoleSeparator(separators);

                if (userDecision ==1)
                {
                    AddEmployee();
                    PrintConsoleSeparator(separators);
                }
                else if (userDecision ==2)
                {
                    AddPost();
                    PrintConsoleSeparator(separators);
                }
                else if (userDecision == 3)
                {
                    RemoveEmployee();
                    PrintConsoleSeparator(separators);
                }
                else if (userDecision ==4)
                {
                    RemovePost();
                    PrintConsoleSeparator(separators);
                }
                else if (userDecision==5)
                {
                    Display();
                    PrintConsoleSeparator(separators);
                }
                else if (userDecision == 6)
                {
                    DisplayAll();
                    PrintConsoleSeparator(separators);
                }
                else
                {
                    Console.WriteLine("Please choose a valid option\n");
                    PrintConsoleSeparator(separators);
                }
            }
        }
        static void AddEmployee()
        {
            string id;
            string name;
            string address;
            double salary;
            Console.Write("ID: ");
            id = Console.ReadLine();
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Address: ");
            address = Console.ReadLine();
            Console.Write("Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
            Employee e1 = new Employee(id, name, address, salary);
            employees.Add(id, e1);
            Console.WriteLine(e1.ToString());
            Console.Write("Employee entered; press any key to continue.");
            Console.ReadLine();
        }

        static void RemoveEmployee()
        { string eID;
            Console.WriteLine("PLease enter the ID of the employee that you'd like to remove");
            eID = Console.ReadLine();
            employees.Remove(eID);
            Console.WriteLine("Your employee has been removed successfully. Press any key to continue.");
            Console.ReadLine();
        }

        static void AddPost()
        {
            string eid;
            string pid;
            string name;
            DateTime startDate;
            DateTime endDate;
            double salary;

            Console.Write("Employee ID: ");
            eid = Console.ReadLine();
            Console.Write("Post ID: ");
            pid = Console.ReadLine();
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Start Date: ");
            startDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("End Date: ");
            endDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());

            Post post = new Post(pid, name, startDate, endDate, salary);

            employees[eid].Posts.Add(pid, post);

            Console.WriteLine("Post entered; press any key to continue");
            Console.ReadLine();
        }

        static void RemovePost()
        {
            string eid;
            string pid;
            Console.Write("Employee ID: ");
            eid = Console.ReadLine();
            Console.Write("Post ID: ");
            pid = Console.ReadLine();
            employees[eid].Posts.Remove(pid);
            Console.WriteLine("Post has been removed for employee id: {0}",eid);
            Console.ReadLine();
        }

        static void Load()
        {
            employees = FileOps.LoadBusiness("e.bin");
            Console.WriteLine("Business loaded; press any key to continue");
            Console.ReadLine();
        }
        static void Display()
        {
            string eid;
            string pid;
            Console.Write("Employee ID: ");
            eid = Console.ReadLine();
            Console.Write("Post ID: ");
            pid = Console.ReadLine();
            Console.WriteLine("Employee Details for id {0}: " + employees[eid].ToString() + "\n Employee with {0} Post details for id {1}: " + employees[eid].Posts[pid].ToString(),eid,pid);

            foreach (Posts post in employees[eid].Posts)
            {
                post.ToString();
            }
        }

        static void DisplayAll()
        {
            foreach(Employee employee in employees)
            {
                for (int i = 1; i <= employees.Count; i++)
                {
                    Console.Write(i + ") ");
                    employee.ToString();
                    Console.WriteLine();
                    foreach (Posts posts in employee.Posts)
                    {
                        posts.ToString();
                    }
                }
            }
        }

        static void Save()
        {
            FileOps.SaveBusiness("e.bin", employees);
            Console.WriteLine("Business saved; press any ket to continue.");
            Console.ReadLine();
        }


        //static void Option4()
        //{
        //    Console.WriteLine(e.Post.ToString());
        //}
        //static void Option5()
        //{
        //    Console.WriteLine(e.ToString());
        //}

        static void PrintConsoleSeparator(int separators)
        {
            Console.WriteLine();
            for (int i=0; i<separators; i++)
            {
                Console.Write("= ");
            }
            Console.WriteLine("\n");
        }
    }
}
