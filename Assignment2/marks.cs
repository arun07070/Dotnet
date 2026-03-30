using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi2
{
    internal class marks
    {
        public static void order()
        {
            int[] marks = new int[10];

            Console.WriteLine("Enter 10 marks:");

            for (int i = 0; i < 10; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = 0, min = marks[0], max = marks[0];

            foreach (int m in marks)
            {
                total += m;

                if (m < min)
                    min = m;

                if (m > max)
                    max = m;
            }

            double avg = (double)total / 10;

            Console.WriteLine("Total: " + total);
            Console.WriteLine("Average: " + avg);
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);

            for (int i = 0; i < marks.Length - 1; i++)
            {
                for (int j = 0; j < marks.Length - i - 1; j++)
                {
                    if (marks[j] > marks[j + 1])
                    {
                        int temp = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Ascending Order:");
            foreach (int m in marks)
                Console.Write(m + " ");

            Console.WriteLine();

            Console.WriteLine("Descending Order:");
            for (int i = marks.Length - 1; i >= 0; i--)
                Console.Write(marks[i] + " ");
        }
    }
}
