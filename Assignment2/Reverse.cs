using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi2
{
    internal class Reverse
    {
        public static void ReverseString()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            char[] arr = word.ToCharArray();
            Array.Reverse(arr);

            string reversed = new string(arr);

            Console.WriteLine("Reversed: " + reversed);
        }
    }
}
