using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Numbers
    {
        static void Main()
        {
            Console.Write("Enter numbers separated by space: ");
            string input = Console.ReadLine();
            int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);
            var result = from n in numbers
                         let sq = n * n
                         where sq > 20
                         select new { Number = n, Square = sq };
            Console.WriteLine("\nResult:");
            foreach (var item in result)
            {
                Console.WriteLine(item.Number + " - " + item.Square);
            }
        }
    }
}
