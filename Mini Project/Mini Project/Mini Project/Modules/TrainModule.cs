using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Project.BAL;
using Mini_Project.Models;

namespace Mini_Project.Modules
{
    internal class TrainModule
    {
        TrainBAL bal = new TrainBAL();

        public void AddTrain()
        {
            Trains t = new Trains();

            Console.Write("Train No : ");
            t.TrainNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Train Name : ");
            t.TrainName = Console.ReadLine();

            Console.Write("From Station : ");
            t.FromStation = Console.ReadLine();

            Console.Write("To Station : ");
            t.ToStation = Console.ReadLine();

            Console.Write("Travel Class (2AC/3AC/Sleeper) : ");
            t.TravelClass = Console.ReadLine();

            Console.Write("Availability : ");
            t.Availability = Convert.ToInt32(Console.ReadLine());

            Console.Write("Charges : ");
            t.Charges = Convert.ToDecimal(Console.ReadLine());

            bal.AddTrain(t);

            Console.WriteLine("Train Added Successfully");
        }

        public void ViewTrains()
        {
            bal.ViewTrains();
        }

        public void DeleteTrain()
        {
            Console.Write("Enter Train Number : ");

            int trainNo = Convert.ToInt32(Console.ReadLine());

            bal.DeleteTrain(trainNo);

            Console.WriteLine("Train Deleted Successfully");
        }
        public void SearchTrain()
        {
            Console.Write("From Station : ");
            string fromStation = Console.ReadLine();

            Console.Write("To Station : ");
            string toStation = Console.ReadLine();

            bal.SearchTrain(fromStation, toStation);
        }
        public void EditTrain()
        {
            Trains train = new Trains();

            Console.Write("Train No : ");
            train.TrainNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Train Name : ");
            train.TrainName = Console.ReadLine();

            Console.Write("From Station : ");
            train.FromStation = Console.ReadLine();

            Console.Write("To Station : ");
            train.ToStation = Console.ReadLine();

            Console.Write("Travel Class : ");
            train.TravelClass = Console.ReadLine();

            Console.Write("Availability : ");
            train.Availability = Convert.ToInt32(Console.ReadLine());

            Console.Write("Charges : ");
            train.Charges = Convert.ToDecimal(Console.ReadLine());

            bal.EditTrain(train);
        }
        public void DeleteTrain(int trainNo)
        {
            bal.DeleteTrain(trainNo);
        }
    }
}