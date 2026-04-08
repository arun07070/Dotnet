using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CodeChallenge2
{
    internal class Negative
    {
        static void CheckNumber(int num)
        {
            if (num < 0)
            {
                throw new Exception("Number cannot be negative!");
            }
            else
            {
                Console.WriteLine("Valid number: " + num);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                CheckNumber(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
            }
            Console.WriteLine("Program ended.");
        }
    }
}
