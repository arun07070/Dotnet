using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi2
{
    internal class compare
    {
        public static void CompareString()
        {
            Console.Write("Enter first word: ");
            string word1 = Console.ReadLine();

            Console.Write("Enter second word: ");
            string word2 = Console.ReadLine();

            if (word1.Equals(word2))
                Console.WriteLine("Both words are same");
            else
                Console.WriteLine("Words are different");
        }
    }
}
