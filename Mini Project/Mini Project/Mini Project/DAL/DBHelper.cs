using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Mini_Project.DAL
{
    internal class DBHelper
    {
        private string conStr =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Mini_Project;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(conStr);
        }
    }
}