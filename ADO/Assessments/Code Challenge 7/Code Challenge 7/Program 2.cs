using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Employee_details
{
    class Employee
    {
        public int Empno { get; set; }
        DataAccess access = new DataAccess();
        public void UpdateSalary()
        {
            Console.WriteLine("Enter Employee ID :");
            Empno = Convert.ToInt32(Console.ReadLine());
            decimal updatedSalary =
                access.UpdateEmployeeSalary(Empno);
            if (updatedSalary > 0)
            {
                Console.WriteLine(
                    "Updated Salary : " + updatedSalary);
            }
            else
            {
                Console.WriteLine("Employee ID Not Found");
            }
        }
        public SqlDataReader DisplayRecords()
        {
            return access.GetEmployees();
        }
    }
    class DataAccess
    {
        static SqlConnection con = null;
        static SqlCommand cmd = null;
        static SqlDataReader dr = null;
        public SqlConnection GetConnection()
        {
            string str =
                "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=Employeemanagement;" +
                "Integrated Security=True";
            con = new SqlConnection(str);
            con.Open();
            return con;
        }
        public decimal UpdateEmployeeSalary(int empid)
        {
            decimal salary = 0;
            try
            {
                con = GetConnection();
                cmd = new SqlCommand(
                    "sp_UpdateSalary", con);
                cmd.CommandType =
                    CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(
                    "@empid", empid);
                SqlParameter outputParam =
                    new SqlParameter();
                outputParam.ParameterName =
                    "@UpdatedSalary";
                outputParam.SqlDbType =
                    SqlDbType.Decimal;
                outputParam.Precision = 10;
                outputParam.Scale = 2;
                outputParam.Direction =
                    ParameterDirection.Output;
                cmd.Parameters.Add(outputParam);
                cmd.ExecuteNonQuery();
                if (cmd.Parameters["@UpdatedSalary"].Value
                    != DBNull.Value)
                {
                    salary = Convert.ToDecimal(
                        cmd.Parameters["@UpdatedSalary"].Value);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return salary;
        }
        public SqlDataReader GetEmployees()
        {
            con = GetConnection();
            cmd = new SqlCommand(
                "select * from Employee_Details",
                con);
            dr = cmd.ExecuteReader();
            return dr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine(
                "------ Update Salary ------");
            emp.UpdateSalary();
            Console.WriteLine(
                "\n------ Employee Records ------");
            SqlDataReader dr =
                emp.DisplayRecords();
            while (dr.Read())
            {
                Console.WriteLine(
                    dr["Empno"] + " " +
                    dr["EmpName"] + " " +
                    dr["Empsal"] + " " +
                    dr["Emptype"]);
            }
            Console.ReadLine();
        }
    }
}