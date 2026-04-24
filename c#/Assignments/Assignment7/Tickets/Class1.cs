using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    public class Class1
    {
        public string CalculateConcession(int age, double totalFare)
        {
            if (age <= 5)
            {
                return "Little Champs - Free Ticket";
            }
            else if (age > 60)
            {
                double finalFare = totalFare - (0.30 * totalFare);
                return "Senior Citizen - Fare: " + finalFare;
            }
            else
            {
                return "Ticket Booked - Fare: " + totalFare;
            }
        }
    }
}