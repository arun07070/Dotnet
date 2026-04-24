using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_1
{
    struct DateOfBirth
    {
        public int Day;
        public int Month;
        public int Year;
    }
    class employees
    {
        public string Name;
        public DateOfBirth Dob;
        public void Display()
        {
            Console.WriteLine("\nEmployee Name: " + Name);
            Console.WriteLine("Date of Birth: " + Dob.Day + "/" + Dob.Month + "/" + Dob.Year);
        }
    }
    class pro
    {
        static void Main(string[] args)
        {
            employees[] emp = new employees[2];
            for (int i = 0; i < emp.Length; i++)
            {
                emp[i] = new employees();
                Console.WriteLine("\nEnter details for Employee " + (i + 1));
                Console.Write("Name of the employee: ");
                emp[i].Name = Console.ReadLine();
                Console.Write("Input day of the birth: ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input month of the birth: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input year of the birth: ");
                int year = Convert.ToInt32(Console.ReadLine());
                emp[i].Dob = new DateOfBirth
                {
                    Day = day,
                    Month = month,
                    Year = year
                };
            }
            Console.WriteLine("\n--- Employee Details ---");
            foreach (employees e in emp)
            {
                e.Display();
            }
        }
    }
}