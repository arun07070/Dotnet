using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_3
{
    internal class Append
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\dotnet\c#\C#\Assessments\Code Challenge 3\Code Challenge 3\TextAppend.txt";
            Console.WriteLine("Enter text to append to the file:");
            string text = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(text);
            }
            Console.WriteLine("Text appended successfully.");
            Console.ReadLine();
        }
    }
}
