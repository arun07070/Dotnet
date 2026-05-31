using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Project.DAL;

namespace Mini_Project.Modules
{
    internal class ReportModule
    {
        ReportDAL reportDAL = new ReportDAL();

        public void TrainReport()
        {
            reportDAL.ShowTrainReport();
        }

        public void BookingReport()
        {
            reportDAL.ShowBookingReport();
        }
    }
}