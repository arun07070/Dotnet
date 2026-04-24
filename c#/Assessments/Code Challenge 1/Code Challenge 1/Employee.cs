using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_1
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Department: {Department}, Salary: {Salary}");
        }
    }
}