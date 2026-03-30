using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi2
{
    internal class display
    {
    public static void Num()
        {
            Console.Write("Enter a digit: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);
            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);
        }
    }
}
