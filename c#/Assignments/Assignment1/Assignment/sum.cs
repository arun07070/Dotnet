using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class sum
    {
        public static void twointeger()
         {
                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int sum = num1 + num2;

                if (num1 == num2)
                {
                    sum = sum * 3;
                }

                Console.WriteLine("Result: " + sum);
            }
        }
    }
