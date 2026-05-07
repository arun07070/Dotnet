using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_1
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }
    class EmployeeDetails
    {
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee { EmployeeID=1001, FirstName="Malcolm", LastName="Daruwalla", Title="Manager", DOB=new DateTime(1984,11,16), DOJ=new DateTime(2011,6,8), City="Mumbai"},
                new Employee { EmployeeID=1002, FirstName="Asdin", LastName="Dhalla", Title="AsstManager", DOB=new DateTime(1984,8,20), DOJ=new DateTime(2012,7,7), City="Mumbai"},
                new Employee { EmployeeID=1003, FirstName="Madhavi", LastName="Oza", Title="Consultant", DOB=new DateTime(1987,11,14), DOJ=new DateTime(2015,4,12), City="Pune"},
                new Employee { EmployeeID=1004, FirstName="Saba", LastName="Shaikh", Title="SE", DOB=new DateTime(1990,6,3), DOJ=new DateTime(2016,2,2), City="Pune"},
                new Employee { EmployeeID=1005, FirstName="Nazia", LastName="Shaikh", Title="SE", DOB=new DateTime(1991,3,8), DOJ=new DateTime(2016,2,2), City="Mumbai"},
                new Employee { EmployeeID=1006, FirstName="Amit", LastName="Pathak", Title="Consultant", DOB=new DateTime(1989,11,7), DOJ=new DateTime(2014,8,8), City="Chennai"},
                new Employee { EmployeeID=1007, FirstName="Vijay", LastName="Natrajan", Title="Consultant", DOB=new DateTime(1989,12,2), DOJ=new DateTime(2015,6,1), City="Mumbai"},
                new Employee { EmployeeID=1008, FirstName="Rahul", LastName="Dubey", Title="Associate", DOB=new DateTime(1993,11,11), DOJ=new DateTime(2014,11,6), City="Chennai"},
                new Employee { EmployeeID=1009, FirstName="Suresh", LastName="Mistry", Title="Associate", DOB=new DateTime(1992,8,12), DOJ=new DateTime(2014,12,3), City="Chennai"},
                new Employee { EmployeeID=1010, FirstName="Sumit", LastName="Shah", Title="Manager", DOB=new DateTime(1991,4,12), DOJ=new DateTime(2016,1,2), City="Pune"}
            };
        }
    }
    internal class Program
    {
        static void Main()
        {
            var employeeData = EmployeeDetails.GetEmployees();
            var before2015Employees = employeeData.Where(emp => emp.DOJ < new DateTime(2015, 1, 1));
            Console.WriteLine("1. Joined before 2015:");
            foreach (var item in before2015Employees)
                Console.WriteLine(item.FirstName);
            var bornAfter1990 = employeeData.Where(emp => emp.DOB > new DateTime(1990, 1, 1));
            Console.WriteLine("\n2. DOB after 1990:");
            foreach (var item in bornAfter1990)
                Console.WriteLine(item.FirstName);
            var consultantAssociateList = employeeData.Where(emp => emp.Title == "Consultant" || emp.Title == "Associate");
            Console.WriteLine("\n3. Consultant & Associate:");
            foreach (var item in consultantAssociateList)
                Console.WriteLine(item.FirstName);
            var employeeCount = employeeData.Count();
            Console.WriteLine($"\n4. Total Employees: {employeeCount}");
            var chennaiEmployeeCount = employeeData.Count(emp => emp.City == "Chennai");
            Console.WriteLine($"5. Chennai Employees: {chennaiEmployeeCount}");
            var highestEmployeeId = employeeData.Max(emp => emp.EmployeeID);
            Console.WriteLine($"6. Highest Employee ID: {highestEmployeeId}");
            var joinedAfter2015Count = employeeData.Count(emp => emp.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine($"7. Joined after 2015: {joinedAfter2015Count}");
            var nonAssociateCount = employeeData.Count(emp => emp.Title != "Associate");
            Console.WriteLine($"8. Not Associate: {nonAssociateCount}");
            var cityWiseEmployees = employeeData.GroupBy(emp => emp.City)
                                                .Select(group => new
                                                {
                                                    CityName = group.Key,
                                                    Total = group.Count()
                                                });
            Console.WriteLine("\n9. Count by City:");
            foreach (var item in cityWiseEmployees)
                Console.WriteLine($"{item.CityName} - {item.Total}");
            var cityAndTitleGroup = employeeData.GroupBy(emp => new { emp.City, emp.Title })
                                                .Select(group => new
                                                {
                                                    group.Key.City,
                                                    group.Key.Title,
                                                    Total = group.Count()
                                                });
            Console.WriteLine("\n10. Count by City & Title:");
            foreach (var item in cityAndTitleGroup)
                Console.WriteLine($"{item.City} - {item.Title} - {item.Total}");
            var youngestEmployeeData = employeeData.OrderByDescending(emp => emp.DOB).First();
            Console.WriteLine($"\n11. Youngest Employee: {youngestEmployeeData.FirstName}");
            Console.ReadLine();
        }
    }
}