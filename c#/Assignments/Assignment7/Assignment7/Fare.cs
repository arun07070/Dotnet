using System;
using Tickets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Fare
    {
        const double TotalFare = 500;
        static void Main()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Class1 ticket = new Class1();
            string result = ticket.CalculateConcession(age, TotalFare);
            Console.WriteLine("\nHello " + name);
            Console.WriteLine(result);
        }
    }
}