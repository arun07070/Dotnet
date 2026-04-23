using Code_Challenge_4.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_4.BL
{
    public class DistanceBL
    {
        private readonly IDistance _distance;
        public DistanceBL(IDistance distance)
        {
            _distance = distance;
        }
        public int CalculateDistance(int d1, int d2)
        {
            return _distance.Add(d1, d2);
        }
    }
}
