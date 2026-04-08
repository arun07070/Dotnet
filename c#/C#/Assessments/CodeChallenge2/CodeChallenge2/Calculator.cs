using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge2
{
    internal class Calculator
    {
        public delegate int Calculate(int a, int b);
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static void PerformOperation(int x, int y, Calculate calc)
        {
            int result = calc(x, y);
            Console.WriteLine("Result: " + result);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n--- Calculator Operations ---");
            PerformOperation(num1, num2, Add);
            PerformOperation(num1, num2, Subtract);
            PerformOperation(num1, num2, Multiply);
        }
    }
}
