using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericList
{
    public class Employee
    {
        public int EmployeeID;
        public string FirstName;
        public string LastName;
        public string Title;
        public string DOB;
        public string DOJ;
        public string City;
    }
    internal class Ques3
    {
        public static void Main()
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = "16/11/1984", DOJ = "8/6/2011", City = "Mumbai" },
                new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = "20/08/1984", DOJ = "7/7/2012", City = "Mumbai" },
                new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = "14/11/1987", DOJ = "12/4/2015", City = "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = "3/6/1990", DOJ = "2/2/2016", City = "Pune" },
                new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = "8/3/1991", DOJ = "2/2/2016", City = "Mumbai" },
                new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = "7/11/1989", DOJ = "8/8/2014", City = "Chennai" },
                new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = "2/12/1989", DOJ = "1/6/2015", City = "Mumbai" },
                new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = "11/11/1993", DOJ = "6/11/2014", City = "Chennai" },
                new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = "12/8/1992", DOJ = "3/12/2014", City = "Chennai" },
                new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = "12/4/1991", DOJ = "2/1/2016", City = "Pune" }
            };
            var allEmployees = empList;
            var notMumbai = empList.Where(e => e.City != "Mumbai");
            var asstManager = empList.Where(e => e.Title == "AsstManager");
            var lastNameS = empList.Where(e => e.LastName.StartsWith("S"));
            Console.WriteLine("a. All Employees:");
            Display(allEmployees);
            Console.WriteLine("\nb. Employees not in Mumbai:");
            Display(notMumbai);
            Console.WriteLine("\nc. Employees with Title AsstManager:");
            Display(asstManager);
            Console.WriteLine("\nd. Employees whose Last Name starts with S:");
            Display(lastNameS);
            Console.ReadLine();
        }
        static void Display(IEnumerable<Employee> list)
        {
            foreach (var emp in list)
            {
                Console.WriteLine($"{emp.EmployeeID} {emp.FirstName} {emp.LastName} {emp.Title} {emp.City}");
            }
        }
    }
}