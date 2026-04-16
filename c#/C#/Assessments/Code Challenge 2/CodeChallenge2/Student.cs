using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CodeChallenge2
{
    abstract class Student
    {
        public string Name;
        public int StudentId;
        public double Grade;
        public abstract bool IsPassed(double grade);
        public void GetDetails()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Student ID: ");
            StudentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Grade: ");
            Grade = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayResult()
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Student ID: " + StudentId);
            Console.WriteLine("Grade: " + Grade);
            if (IsPassed(Grade))
                Console.WriteLine("Result: Passed");
            else
                Console.WriteLine("Result: Failed");
        }
    }
    class Undergraduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }
    class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Student Type:");
            Console.WriteLine("1. Undergraduate");
            Console.WriteLine("2. Graduate");
            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Student student;
            if (choice == 1)
                student = new Undergraduate();
            else
                student = new Graduate();
            student.GetDetails();
            student.DisplayResult();
        }
    }
}
