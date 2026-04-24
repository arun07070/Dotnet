using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Word
    {
        static void Main()
        {
            Console.Write("Enter words separated by space: ");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            var result = from w in words
                         where w.StartsWith("a") && w.EndsWith("m")
                         select w;
            if (result.Any())
            {
                Console.WriteLine("\nMatched words:");
                foreach (string word in result)
                {
                    Console.WriteLine(word);
                }
            }
            else
            {
                Console.WriteLine("\nNo Match Found");
            }
        }
    }
}
