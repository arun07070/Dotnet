using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Remove
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            Console.Write("Enter position to remove: ");
            int pos = int.Parse(Console.ReadLine());
            if (pos >= 0 && pos < str.Length)
            {
                string result = str.Remove(pos, 1);
                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Invalid position!");
            }
        }
    }
}
