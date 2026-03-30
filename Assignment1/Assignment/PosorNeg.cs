using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class PosorNeg
    {
        public static void Pos()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine(num + " is a positive number");
            }
            else if (num < 0)
            {
                Console.WriteLine(num + " is a negative number");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }
        }
    }
}
