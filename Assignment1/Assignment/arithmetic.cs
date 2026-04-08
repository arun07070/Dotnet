using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class arithmetic
    {
        public static void operations()
        {
        Console.Write("Input first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
        Console.WriteLine(num1 + " * " + num2 + " = " + (num1* num2));

        if (num2 != 0)
        {
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed");
        }
    }
    }
}
