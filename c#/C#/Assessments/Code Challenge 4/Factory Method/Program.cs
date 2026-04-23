using Factory_Method.Contracts;
using Factory_Method.Creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter report type (Chart / Tabular / Summary): ");
            string input = Console.ReadLine().ToLower();
            BaseFactory factory = null;
            switch (input)
            {
                case "chart":
                    factory = new ChartCreator();
                    break;
                case "tabular":
                    factory = new TabularCreator();
                    break;
                case "summary":
                    factory = new SummaryCreator();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }
            IReport report = factory.CreateReport();
            report.GenerateReport();
        }
    }
}
