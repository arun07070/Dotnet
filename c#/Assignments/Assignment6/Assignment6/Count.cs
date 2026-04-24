using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment6
{
    internal class Count
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter file name: ");
                string path = Console.ReadLine();
                int count = File.ReadAllLines(path).Length;
                Console.WriteLine("Number of lines in file: " + count);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.ReadLine();
        }
    }
}
