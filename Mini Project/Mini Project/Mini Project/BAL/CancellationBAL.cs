using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Project.DAL;

namespace Mini_Project.BAL
{
    internal class CancellationBAL
    {
        CancellationDAL cancellationDAL = new CancellationDAL();

        public void CancelTicket(int bookingId)
        {
            cancellationDAL.CancelTicket(bookingId);
        }
        public void ViewCancellations()
        {
            cancellationDAL.ViewCancellations();
        }
    }
}