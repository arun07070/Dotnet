using System;
using Mini_Project.DAL;
using Mini_Project.Models;

namespace Mini_Project.BAL
{
    internal class UserBAL
    {
        UserDAL userDAL = new UserDAL();

        public bool Login(string username, string password, string userType)
        {
            return userDAL.Login(username, password, userType);
        }

        public void Register(User user)
        {
            userDAL.Register(user);
        }
    }
}