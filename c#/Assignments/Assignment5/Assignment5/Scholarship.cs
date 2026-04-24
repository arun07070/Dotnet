using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment5
{
    class InvalidMarksException : Exception
    {
        public InvalidMarksException(string message) : base(message) { }
    }
    internal class Scholarship
    {
        public double Merit(int marks, double fees)
        {
            if (marks >= 70 && marks <= 80)
                return fees * 0.20;
            else if (marks > 80 && marks <= 90)
                return fees * 0.30;
            else if (marks > 90)
                return fees * 0.50;
            else
                throw new InvalidMarksException("Not eligible for scholarship");
        }
        static void Main(string[] args)
        {
            try
            {
                Scholarship s = new Scholarship();
                Console.Write("Enter Marks: ");
                int marks = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Fees: ");
                double fees = Convert.ToDouble(Console.ReadLine());
                double result = s.Merit(marks, fees);
                Console.WriteLine("Scholarship Amount: " + result);
            }
            catch (InvalidMarksException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter numeric values.");
            }
            Console.ReadLine();
        }
    }
}