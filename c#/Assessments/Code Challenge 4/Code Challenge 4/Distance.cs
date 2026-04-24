using Code_Challenge_4.BL;
using Code_Challenge_4.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_4
{
    class Distance
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first distance: ");
            int d1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second distance: ");
            int d2 = Convert.ToInt32(Console.ReadLine());
            DistanceBL bl = new DistanceBL(new DistanceClass());
            int result = bl.CalculateDistance(d1, d2);
            Console.WriteLine("Total Distance: " + result + " km");
        }
    }
}