using Factory_Method.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Creators
{
    public abstract class BaseFactory
    {
        public abstract IReport CreateReport();
    }
}
