using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeService service = new EmployeeService();
            int choice;

            do
            {
                Console.WriteLine("\n===== Employee Management Menu =====");
                Console.WriteLine("1. Add New Employee");
                Console.WriteLine("2. View All Employees");
                Console.WriteLine("3. Search Employee by ID");
                Console.WriteLine("4. Update Employee Details");
                Console.WriteLine("5. Delete Employee");
                Console.WriteLine("6. Exit");
                Console.WriteLine("====================================");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.AddEmployee();
                        break;

                    case 2:
                        service.ViewEmployees();
                        break;

                    case 3:
                        service.SearchEmployee();
                        break;

                    case 4:
                        service.UpdateEmployee();
                        break;

                    case 5:
                        service.DeleteEmployee();
                        break;

                    case 6:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 6);
        }
    }
}