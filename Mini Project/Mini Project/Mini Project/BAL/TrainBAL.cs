using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Project.DAL;
using Mini_Project.Models;

namespace Mini_Project.BAL
{
    internal class TrainBAL
    {
        TrainDAL trainDAL = new TrainDAL();

        public void AddTrain(Trains train)
        {
            trainDAL.AddTrain(train);
        }

        public void ViewTrains()
        {
            trainDAL.ViewTrains();
        }

        public void DeleteTrain(int trainNo)
        {
            trainDAL.DeleteTrain(trainNo);
        }
    }
}