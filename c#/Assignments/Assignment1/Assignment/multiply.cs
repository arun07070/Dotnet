using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class multiply
    {
        public static void table()
        {
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(num + " * " + i + " = " + (num* i));
        }
}
    }
}
