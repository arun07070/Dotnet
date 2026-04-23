using Factory_Method.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Report_Types
{
    public class TabularReport : IReport
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating Tabular Report...");
        }
    }
}
