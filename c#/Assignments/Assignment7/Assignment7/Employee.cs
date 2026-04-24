using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public string EmpCity { get; set; }
    public double EmpSalary { get; set; }
}
class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();
        Console.Write("Enter number of employees: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Employee emp = new Employee();
            Console.WriteLine("\nEnter details for Employee " + (i + 1));
            Console.Write("EmpId: ");
            emp.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.Write("EmpName: ");
            emp.EmpName = Console.ReadLine();
            Console.Write("EmpCity: ");
            emp.EmpCity = Console.ReadLine();
            Console.Write("EmpSalary: ");
            emp.EmpSalary = Convert.ToDouble(Console.ReadLine());
            employees.Add(emp);
        }
        Console.WriteLine("\n--- All Employees ---");
        foreach (Employee emp in employees)
        {
            Console.WriteLine(emp.EmpId + " " + emp.EmpName + " " + emp.EmpCity + " " + emp.EmpSalary);
        }
        Console.WriteLine("\n--- Employees with Salary > 45000 ---");
        var highSalary = from e in employees
                         where e.EmpSalary > 45000
                         select e;
        bool foundHighSalary = false;
        foreach (Employee emp in highSalary)
        {
            Console.WriteLine(emp.EmpName + " " + emp.EmpSalary);
            foundHighSalary = true;
        }
        if (!foundHighSalary)
        {
            Console.WriteLine("No Employees Found");
        }
        Console.WriteLine("\n--- Employees from Bangalore ---");
        var bangalore = from e in employees
                        where e.EmpCity.ToLower() == "bangalore"
                        select e;
        bool foundBangalore = false;
        foreach (Employee emp in bangalore)
        {
            Console.WriteLine(emp.EmpName + " " + emp.EmpCity);
            foundBangalore = true;
        }
        if (!foundBangalore)
        {
            Console.WriteLine("No Employees Found");
        }
        Console.WriteLine("\n--- Employees Sorted by Name ---");
        var sorted = from e in employees
                     orderby e.EmpName ascending
                     select e;
        foreach (Employee emp in sorted)
        {
            Console.WriteLine(emp.EmpName + " " + emp.EmpCity + " " + emp.EmpSalary);
        }
    }
}