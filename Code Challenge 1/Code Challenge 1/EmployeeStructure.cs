using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_1
{
    internal class EmployeeService
    {
        private List<Employee> employees = new List<Employee>();
        public void AddEmployee()
        {
            Employee emp = new Employee();

            Console.Write("Enter ID: ");
            emp.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            emp.Name = Console.ReadLine();

            Console.Write("Enter Department: ");
            emp.Department = Console.ReadLine();

            Console.Write("Enter Salary: ");
            emp.Salary = Convert.ToDouble(Console.ReadLine());

            employees.Add(emp);
            Console.WriteLine("Employee added successfully!");
        }
        public void ViewEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees found.");
                return;
            }

            foreach (var emp in employees)
            {
                emp.Display();
            }
        }
        public void SearchEmployee()
        {
            Console.Write("Enter ID to search: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Employee emp = employees.Find(e => e.Id == id);

            if (emp != null)
                emp.Display();
            else
                Console.WriteLine("Employee not found.");
        }
        public void UpdateEmployee()
        {
            Console.Write("Enter ID to update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Employee emp = employees.Find(e => e.Id == id);

            if (emp != null)
            {
                Console.Write("Enter New Name: ");
                emp.Name = Console.ReadLine();

                Console.Write("Enter New Department: ");
                emp.Department = Console.ReadLine();

                Console.Write("Enter New Salary: ");
                emp.Salary = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Employee updated successfully!");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
        public void DeleteEmployee()
        {
            Console.Write("Enter ID to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Employee emp = employees.Find(e => e.Id == id);

            if (emp != null)
            {
                employees.Remove(emp);
                Console.WriteLine("Employee deleted successfully!");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
    }
}