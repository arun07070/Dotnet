using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi2
{
    internal class average
    {
        public static void Minandmax()
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            int sum = 0, min = arr[0], max = arr[0];

            foreach (int num in arr)
            {
                sum += num;

                if (num < min)
                    min = num;

                if (num > max)
                    max = num;
            }

            double avg = (double)sum / arr.Length;

            Console.WriteLine("Average: " + avg);
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);
        }
    }
}
