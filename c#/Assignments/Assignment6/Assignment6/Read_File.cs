using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Assignment6
{
    internal class Read_File
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter file name: ");
                string path = Console.ReadLine();
                Console.Write("Enter number of lines: ");
                int n = Convert.ToInt32(Console.ReadLine());
                string[] lines = new string[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Enter line " + (i + 1) + ": ");
                    lines[i] = Console.ReadLine();
                }
                File.WriteAllLines(path, lines);
                Console.WriteLine("\nData written successfully.\n");
                Console.WriteLine("Reading from file:");
                string[] readLines = File.ReadAllLines(path);
                foreach (string line in readLines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.ReadLine();
        }

    }
}
