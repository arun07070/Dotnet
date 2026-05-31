using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project.Models
{
    internal class Trains
    {
        public int TrainNo { get; set; }

        public string TrainName { get; set; }

        public string FromStation { get; set; }

        public string ToStation { get; set; }

        public string TravelClass { get; set; }

        public int Availability { get; set; }

        public decimal Charges { get; set; }

        public bool IsDeleted { get; set; }
    }
}