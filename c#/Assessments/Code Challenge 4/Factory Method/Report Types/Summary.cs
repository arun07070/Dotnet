using Factory_Method.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Report_Types
{
    public class SummaryReport : IReport
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating Summary Report...");
        }
    }
}
