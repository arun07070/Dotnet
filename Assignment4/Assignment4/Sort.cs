using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Sort
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
            {
                stack.Push(int.Parse(Console.ReadLine()));
            }
            List<int> list = new List<int>(stack);
            list.Sort();
            Stack<int> sortedStack = new Stack<int>();
            foreach (int item in list)
            {
                sortedStack.Push(item);
            }
            Console.WriteLine("Stack in descending order:");
            while (sortedStack.Count > 0)
            {
                Console.WriteLine(sortedStack.Pop());
            }
        }
    }
}
