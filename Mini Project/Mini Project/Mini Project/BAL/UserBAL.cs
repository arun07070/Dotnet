using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Project.DAL;
using Mini_Project.Models;

namespace Mini_Project.BAL
{
    internal class UserBAL
    {
        UserDAL userDAL = new UserDAL();

        public bool Register(User user)
        {
            return userDAL.Register(user);
        }
    }
}