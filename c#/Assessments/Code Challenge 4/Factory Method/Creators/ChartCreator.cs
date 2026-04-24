using Factory_Method.Contracts;
using Factory_Method.Report_Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Creators
{
    public class ChartCreator : BaseFactory
    {
        public override IReport CreateReport()
        {
            return new ChartReport();
        }
    }
}
