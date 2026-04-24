using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi2
{
    internal class length
    {
        public static void Stringlen()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            Console.WriteLine("Length: " + word.Length);
        }
    }
}
